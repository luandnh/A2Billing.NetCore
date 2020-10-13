using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsService.Base.Model;
using NesopsService.Data;
using NesopsService.Data.Entities;

namespace NesopsRTC2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private Mya2billingContext _dbContext;
        private IMapper _mapper;

        public ChartController(Mya2billingContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("logcall")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, int>>>> CallData(CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<CcCall>();
            var startDate = DateTime.Now.AddDays(-9);
            var endDate = DateTime.Now;
            var latestCall = query.OrderBy(x => x.Id).ToList().LastOrDefault();
            if (latestCall != null)
            {
                startDate = latestCall.Starttime.AddDays(-9);
                endDate = latestCall.Starttime;
            }
            var result = new Dictionary<string, int>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var count =( await query.Where(p => p.Starttime.Date == date.Date).ToListAsync(cancellationToken)).Count();
                result[date.Date.ToString("dd/MM/yyyy")] = count;
            }
            return Ok(new BaseResponseModel<Dictionary<string, int>> { message="Successful",data = result });
        }
        [HttpGet]
        [Route("logcall/{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, int>>>> AccountCallData(long id,CancellationToken cancellationToken)
        {
            var query = await _dbContext.Set<CcCall>().Where(p=>p.CardId == id).OrderBy(x => x.Id).ToListAsync(cancellationToken);
            if (query.Count == 0) {
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            }
            var startDate = query.LastOrDefault().Starttime.AddDays(-9);
            var endDate = query.LastOrDefault().Starttime;
            var result = new Dictionary<string, int>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var count = query.Where(p => p.Starttime.Date == date.Date).Count();
                result[date.Date.ToString("dd/MM/yyyy")] = count;
            }
            return Ok(new BaseResponseModel<Dictionary<string, int>> { message = "Successful", data = result });
        }
        [HttpGet]
        [Route("systemdata")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, double>>>> SystemData(CancellationToken cancellationToken)
        {
            var result = new Dictionary<string, double>();
            var accounts = await _dbContext.Set<CcCard>().AsNoTracking().ToListAsync(cancellationToken);
            var vouchers = await _dbContext.Set<CcVoucher>().AsNoTracking().ToListAsync(cancellationToken);
            var calls = await _dbContext.Set<CcCall>().AsNoTracking().ToListAsync(cancellationToken);
            var logrefills = await _dbContext.Set<CcLogrefill>().AsNoTracking().ToListAsync(cancellationToken);
            var logpayments = await _dbContext.Set<CcLogpayment>().AsNoTracking().ToListAsync(cancellationToken);
            var supports = await _dbContext.Set<CcTicket>().AsNoTracking().ToListAsync(cancellationToken);

            double totalCost = 0;
            int busyCall = 0;
            int completeCall = 0;
            int callDuration = 0;
            calls.ForEach(p =>
            {
                if (p.Buycost != null) totalCost += Convert.ToDouble(p.Buycost);
                if (p.Sessiontime != null) callDuration += Convert.ToInt32(p.Sessiontime);
                if (p.Terminatecauseid == 1) completeCall += 1;
                if (p.Terminatecauseid == 2) busyCall += 1;
            });
            totalCost = Math.Round(totalCost, 2, MidpointRounding.ToEven);

            result["Customers"] = accounts.Count();
            result["CustomersActived"] = accounts.Where(p=>p.Activated=="f").Count();
            result["CustomersNotActived"] = accounts.Where(p=>p.Activated=="t").Count();
            result["Vouchers"] = vouchers.Count();
            result["Calls"] = calls.Count();
            result["CallDuration"] = callDuration;
            result["CallAnswered"] = completeCall;
            result["CallBusy"] = busyCall;
            result["CallCancelled"] = calls.Count()-completeCall-busyCall;
            result["TotalCost"] = totalCost;
            result["LogRefills"] = logrefills.Count();
            result["LogPayments"] = logpayments.Count();
            result["Supports"] = supports.Count();

            return Ok(new BaseResponseModel<Dictionary<string, double>> { message = "Successful", data = result });
        }
        [HttpGet]
        [Route("accountdata/{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, double>>>> SystemData(long id, CancellationToken cancellationToken)
        {
            var result = new Dictionary<string, double>();
            var account = await _dbContext.Set<CcCard>().AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if(account == null) {
                return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
            }
            var vouchers = await _dbContext.Set<CcVoucher>().AsNoTracking().Where(p => p.Usedcardnumber == account.Username).ToListAsync(cancellationToken);
            var calls = await _dbContext.Set<CcCall>().AsNoTracking().Where(p => p.CardId == id).ToListAsync(cancellationToken);
            var logrefills = await _dbContext.Set<CcLogrefill>().AsNoTracking().Where(p => p.CardId == id).ToListAsync(cancellationToken);
            var logpayments = await _dbContext.Set<CcLogpayment>().AsNoTracking().Where(p => p.CardId == id).ToListAsync(cancellationToken);
            var supports = await _dbContext.Set<CcTicket>().AsNoTracking().Where(p => p.Creator == id).ToListAsync(cancellationToken);

            double totalCost = 0;
            int busyCall = 0;
            int completeCall = 0;
            int callDuration = 0;
            calls.ForEach(p =>
            {
                if (p.Buycost != null) totalCost += Convert.ToDouble(p.Buycost);
                if (p.Sessiontime != null) callDuration += Convert.ToInt32(p.Sessiontime);
                if (p.Terminatecauseid == 1) completeCall += 1;
                if (p.Terminatecauseid == 2) busyCall += 1;
            });
            totalCost = Math.Round(totalCost, 2, MidpointRounding.ToEven);
            result["Vouchers"] = vouchers.Count();
            result["Calls"] = calls.Count();
            result["CallDuration"] = callDuration;
            result["CallAnswered"] = completeCall;
            result["CallBusy"] = busyCall;
            result["CallCancelled"] = calls.Count() - completeCall - busyCall;
            result["TotalCost"] = totalCost;
            result["LogRefills"] = logrefills.Count();
            result["LogPayments"] = logpayments.Count();
            result["Supports"] = supports.Count();

            return Ok(new BaseResponseModel<Dictionary<string, double>> { message = "Successful", data = result });
        }
        [HttpGet]
        [Route("logrefill")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, int>>>> LogRefillData(CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<CcLogrefill>();
            var startDate = DateTime.Now.AddDays(-9);
            var endDate = DateTime.Now;
            var latestData = query.OrderBy(x => x.Id).ToList().LastOrDefault();
            if (latestData != null)
            {
                startDate = latestData.Date.AddDays(-9);
                endDate = latestData.Date;
            }
            var result = new Dictionary<string, int>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var count = (await query.Where(p => p.Date.Date == date.Date).ToListAsync(cancellationToken)).Count();
                result[date.Date.ToString("dd/MM/yyyy")] = count;
            }
            return Ok(new BaseResponseModel<Dictionary<string, int>> { message = "Successful", data = result });
        }
        [HttpGet]
        [Route("logpayment")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<Dictionary<string, int>>>> LogPaymentData(CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<CcLogpayment>();
            var startDate = DateTime.Now.AddDays(-9);
            var endDate = DateTime.Now;
            var latestData = query.OrderBy(x => x.Id).ToList().LastOrDefault();
            if (latestData != null)
            {
                startDate = latestData.Date.AddDays(-9);
                endDate = latestData.Date;
            }
            var result = new Dictionary<string, int>();
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var count = (await query.Where(p => p.Date.Date == date.Date).ToListAsync(cancellationToken)).Count();
                result[date.Date.ToString("dd/MM/yyyy")] = count;
            }
            return Ok(new BaseResponseModel<Dictionary<string, int>> { message = "Successful", data = result });
        }
    }
}