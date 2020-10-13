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
    public class ContactController : BaseEntityController<Mya2billingContext, CcContact, CcContactReadModel, CcContactCreateModel, CcContactUpdateModel, CcContactRequestModel>
    {
        public ContactController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcContactReadModel>>>> GetAll([FromQuery]  CcContactRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcContactReadModel>>> GetOne(long id, [FromQuery] CcContactRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcContactReadModel>> Add([FromBody]CcContactCreateModel createModel, CancellationToken cancellationToken)
        {
            var checkCard = _dbContext.Set<CcCard>().AsNoTracking().FirstOrDefault(p => p.Id == createModel.CardId);
            if (checkCard == null)
            {
                return NotFound(new BaseResponseModel<object> { success = false, message = "Card Id Not found", code = 404 });
            }
            var checkPhoneNumber = _dbContext.Set<CcContact>().FirstOrDefault(p => p.Phonenumber == createModel.Phonenumber);
            if (checkPhoneNumber != null) {
                return BadRequest(new BaseResponseModel<object> { success = false, message = "Phone Number is existed!", code = 400 });
            }
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcContactReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcContactReadModel>> Update(long id, CcContactUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var checkPhoneNumber = _dbContext.Set<CcContact>().FirstOrDefault(p => p.Id != id && p.Phonenumber == updateModel.Phonenumber);
            if (checkPhoneNumber != null)
            {
                return BadRequest(new BaseResponseModel<object> { success = false, message = "Phone Number is existed!", code = 400 });
            }
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcContactReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
        protected override IQueryable<CcContact> HandleRequest(CcContactRequestModel request)
        {
            var readModels = _dbContext.Set<CcContact>().AsNoTracking().Where(p =>
                (request.cardId == null || request.cardId == p.CardId)
            );
            return readModels;
        }
    }
}