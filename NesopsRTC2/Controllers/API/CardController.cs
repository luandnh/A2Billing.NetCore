using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsRTC2.Utils;
using NesopsService.Base.Controller;
using NesopsService.Base.Model;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Models.RequestModels;

namespace NesopsRTC2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : BaseEntityController<Mya2billingContext, CcCard, CcCardReadModel, CcCardCreateModel, CcCardUpdateModel, CcCardRequestModel>
    {
        public CardController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcCardReadModel>>>> GetAll([FromQuery]  CcCardRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcCardReadModel>>> GetOne(long id, [FromQuery] CcCardRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCardReadModel>> Add([FromBody]CcCardCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCardReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCardReadModel>> Update(long id, CcCardUpdateModel updateModel, CancellationToken cancellationToken)
        {
            if (updateModel.Email != "")
            {
                var checkEmailExisted = _dbContext.Set<CcCard>().FirstOrDefault(p => p.Id != id && p.Email == updateModel.Email);
                if (checkEmailExisted != null)
                {
                    return BadRequest(new BaseResponseModel<object> { success = false, message = "Email is existed!", code = 400 });
                }
            }
            string pass = updateModel.Uipass;
            var checkPass = Regex.IsMatch(pass, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
            if (!checkPass)
            {
                updateModel.Uipass = NesopsUtil.GenerateMD5FromString(updateModel.Username + ":a2billing:" + pass);
                var sipUser = _dbContext.Set<CcSipBuddies>().FirstOrDefault(p => p.IdCcCard == id);
                string accountCode = sipUser.Accountcode;
                string md5secret = NesopsUtil.GenerateMD5FromString(accountCode + ":asterisk:" + pass);
                sipUser.Md5secret = md5secret;
                sipUser.Secret = "";
                _dbContext.Set<CcSipBuddies>().Update(sipUser);
                await _dbContext.SaveChangesAsync();
            }
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcCardReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
        protected override IQueryable<CcCard> HandleRequest(CcCardRequestModel request)
        {
            var readModels = _dbContext.Set<CcCard>().AsNoTracking().Where(p =>
                (request.Username == null || request.Username == p.Username)
            );
            return readModels;
        }
    }
}