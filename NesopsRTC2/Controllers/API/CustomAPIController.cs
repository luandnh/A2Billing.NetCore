using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsRTC2.Utils;
using NesopsService.Base.Model;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Models.RequestModels;
using NesopsService.Services;

namespace NesopsRTC2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomAPIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly Mya2billingContext _dbContext;
        public CustomAPIController(Mya2billingContext dbcontext, IMapper mapper)
        {
            _dbContext = dbcontext;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("refill/{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<object>> Refill(long id, [FromBody] CustomerCredit customer, CancellationToken cancellationToken)
        {
            var card = _dbContext.Set<CcCard>().FirstOrDefault(p => p.Id == id);
            if (card == null /*|| card.Activated != "t"*/)
            {
                return NotFound(new BaseResponseModel<object> { success = false, message = "Card Not found", code = 404 });
            }
            if (customer.description == null || customer.description.Trim() == "")
            {
                customer.description = "Refill Using API";
            }
            var VAT = card.Vat;
            var credited = (Convert.ToDouble(customer.credit) * (100 - VAT) / 100);
            var currentBalance = card.Credit + Convert.ToDecimal(credited);
            card.Credit = currentBalance;
            //Update Card with Credit
            var updateTask = _dbContext.Set<CcCard>().Update(card);
            if (updateTask.State == EntityState.Modified)
            {
                var logRefill = new CcLogrefill()
                {
                    CardId = card.Id,
                    Date = DateTime.Now,
                    Description = customer.description,
                    Credit = Convert.ToDecimal(credited),
                    RefillType = 1,
                    AddedInvoice = 1,
                    AgentId = null
                };
                var logRefillRes = await _dbContext.Set<CcLogrefill>().AddAsync(logRefill);
                await _dbContext.SaveChangesAsync(cancellationToken);
                var res = new Dictionary<string, object>();
                res["card_id"] = card.Id;
                res["credit_without_vat"] = customer.credit;
                res["credited"] = credited;
                res["current_balance"] = currentBalance;
                res["logrefill_id"] = logRefillRes.Entity.Id;
                res["vat"] = card.Vat;

                return Ok(new BaseResponseModel<IDictionary<string, object>> { message = "Refill Successful", data = res, code = (int)HttpStatusCode.OK });
            }
            return BadRequest(new BaseResponseModel<object> { success = false, message = "Cannot Update Card", code = 400 });
        }

        /// <summary>
        /// Generate Voucher Function
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("voucher/generate")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<object>> GenerateVoucher(VoucherGenerateModel model, CancellationToken cancellationToken)
        {
            int i = 1;
            IDictionary<string, string> result = new Dictionary<string, string>();
            List<CcVoucher> listVoucher = new List<CcVoucher>();
            var voucherTable = _dbContext.Set<CcVoucher>();
            while (i <= model.quantity)
            {
                var checkExist = false;
                var voucherCode = "";
                do
                {
                    voucherCode = NesopsUtil.GetRandomStringNumber(15);
                    checkExist = voucherTable.FirstOrDefault(p => p.Voucher == voucherCode) != null;
                } while (checkExist == true);
                result.Add("Code " + i, voucherCode);

                var voucher = new CcVoucher()
                {
                    Activated = "t",
                    Creationdate = DateTime.UtcNow.AddHours(7),
                    Credit = model.credit,
                    Currency = "USD",
                    Expirationdate = model.exprireDate,
                    Voucher = voucherCode
                };
                listVoucher.Add(voucher);
                i++;
            }
            await voucherTable.AddRangeAsync(listVoucher, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Ok(new BaseResponseModel<IDictionary<string, string>> { message = "Generate Voucher Successful", data = result, code = (int)HttpStatusCode.OK });
        }

        [HttpPost]
        [Route("md5secret/generate")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<object>> GenerateMD5ForAllAccounts(CancellationToken cancellationToken)
        {
            var users = await _dbContext.Set<CcSipBuddies>().ToListAsync();
            foreach (var user in users)
            {
                if (user.Secret == "" && user.Md5secret != "")
                    continue;
                string secret = user.Secret;
                string accountCode = user.Accountcode;
                string md5secret = NesopsUtil.GenerateMD5FromString(accountCode + ":asterisk:" + secret);
                user.Md5secret = md5secret;
                user.Secret = "";
                _dbContext.Set<CcSipBuddies>().Update(user);
                await _dbContext.SaveChangesAsync();
            }
            users = await _dbContext.Set<CcSipBuddies>().ToListAsync();
            return Ok(new BaseResponseModel<List<CcSipBuddies>> { message = "Generate md5secret for all account successful", data = users, code = (int)HttpStatusCode.OK });
        }
        [HttpPost]
        [Route("md5secret/generate/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<object>> GenerateMD5ForAccount(long id, CancellationToken cancellationToken)
        {
            var user = _dbContext.Set<CcSipBuddies>().FirstOrDefault(p => p.Id == id);
            if (user == null) return null;
            if (user.Secret == "" && user.Md5secret != "")
                return BadRequest(new BaseResponseModel<CcSipBuddies> { message = "This account has been generated md5secret", data = user, code = 400 });
            string secret = user.Secret;
            string accountCode = user.Accountcode;
            string md5secret = NesopsUtil.GenerateMD5FromString(accountCode + ":asterisk:" + secret);
            user.Md5secret = md5secret;
            user.Secret = "";
            _dbContext.Set<CcSipBuddies>().Update(user);
            await _dbContext.SaveChangesAsync();
            user = _dbContext.Set<CcSipBuddies>().FirstOrDefault(p => p.Id == id);
            return Ok(new BaseResponseModel<CcSipBuddies> { message = "Generate md5secret for account successful", data = user, code = (int)HttpStatusCode.OK });
        }
        [HttpPost]
        [Route("password/generate")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<object>> GeneratePasswordForAllAccounts(CancellationToken cancellationToken)
        {
            var users = await _dbContext.Set<CcCard>().ToListAsync();
            foreach (var user in users)
            {
                string pass = user.Uipass;
                var checkPass = Regex.IsMatch(pass, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
                if (checkPass || user.Status != 1)
                {
                    continue;
                }
                string md5password = NesopsUtil.GenerateMD5FromString(user.Username + ":a2billing:" + pass);
                user.Uipass = md5password;
                _dbContext.Set<CcCard>().Update(user);
                await _dbContext.SaveChangesAsync();
            }
            users = await _dbContext.Set<CcCard>().ToListAsync();
            return Ok(new BaseResponseModel<List<CcCard>> { message = "Generate md5password for all account successful", data = users, code = (int)HttpStatusCode.OK });
        }
        [HttpPost]
        [Route("password/generate/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<object>> GeneratePasswordForAccount(long id, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Set<CcCard>().FirstOrDefaultAsync(p => p.Id == id);
            string pass = user.Uipass;
            var checkPass = Regex.IsMatch(pass, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
            if (checkPass)
            {
                return BadRequest(new BaseResponseModel<CcCard> { message = "This account has been generated password", data = user, code = 400 });
            }
            if (user.Status != 1)
            {
                return BadRequest(new BaseResponseModel<CcCard> { message = "This account is not activated", data = user, code = 400 });
            }
            string md5password = NesopsUtil.GenerateMD5FromString(user.Username+":a2billing:" + pass);
            user.Uipass = md5password;
            _dbContext.Set<CcCard>().Update(user);
            await _dbContext.SaveChangesAsync();
            user = await _dbContext.Set<CcCard>().FirstOrDefaultAsync(p => p.Id == id);
            return Ok(new BaseResponseModel<CcCard> { message = "Generate md5password for account successful", data = user, code = (int)HttpStatusCode.OK });
        }
    }
    public class CustomerCredit
    {
        public decimal credit { get; set; }
        public string description { get; set; }
    }
}