using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsRTC2.Models;
using NesopsService.Base.Model;
using NesopsService.Data;
using NesopsService.Data.Entities;

namespace NesopsRTC2.Controllers
{
    public class VoucherController : Controller
    {
        private readonly IMapper _mapper;
        private readonly Mya2billingContext _dbContext;
        public VoucherController(Mya2billingContext dbcontext, IMapper mapper)
        {
            _dbContext = dbcontext;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> UseVoucher([FromBody] VoucherModel voucherModel, CancellationToken cancellationToken)
        {
            var voucher = _dbContext.Set<CcVoucher>().FirstOrDefault(p => p.Voucher == voucherModel.voucherCode && p.Activated == "t");
            if (voucher == null) return NotFound(new BaseResponseModel<object> { message = "Voucher Not found!", code = 404 });
            if (voucher.Expirationdate < DateTime.UtcNow.AddHours(7)) return NotFound(new BaseResponseModel<object> { message = "Voucher is Expired!", code = 404 });
            var card = _dbContext.Set<CcCard>().FirstOrDefault(p => p.Id == voucherModel.cardId);
            if (card == null /*|| card.Activated != "t"*/)
            {
                return NotFound(new BaseResponseModel<object> { message = "Card Not found", code = 404 });
            }

            //Update Card Credit
            var currentBalance = card.Credit + Convert.ToDecimal(voucher.Credit);
            card.Credit = currentBalance;
            var updateTask = _dbContext.Set<CcCard>().Update(card);
            if (updateTask.State != EntityState.Modified) 
                return BadRequest(new BaseResponseModel<object> { message = "Use Voucher Fail", code = 400 });

            //Update Voucher State
            voucher.Usedate = DateTime.Now;
            voucher.Usedcardnumber = card.Username;
            voucher.Used = 1;
            voucher.Activated = "f";
            var updateVoucherTask = _dbContext.Set<CcVoucher>().Update(voucher);
            if (updateVoucherTask.State != EntityState.Modified)
                return BadRequest(new BaseResponseModel<object> { message = "Use Voucher Fail", code = 400 });

            //Create Log Refill
            var logRefill = new CcLogrefill()
            {
                CardId = card.Id,
                Date = DateTime.Now,
                Description = card.Username + " use voucher",
                Credit = Convert.ToDecimal(voucher.Credit),
                RefillType = 1,
                AddedInvoice = 1,
                AgentId = null
            };
            var addLogTask = await _dbContext.Set<CcLogrefill>().AddAsync(logRefill);
            if (addLogTask.State != EntityState.Added)
                return BadRequest(new BaseResponseModel<object> { message = "Use Voucher Fail", code = 400 });

            //Commit
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Ok(new BaseResponseModel<object> { message = "Refill Successful", code = (int)HttpStatusCode.OK });
        }
    }
}