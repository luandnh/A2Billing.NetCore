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
    public class CallController : BaseEntityController<Mya2billingContext, CcCall, CcCallReadModel, CcCallCreateModel, CcCallUpdateModel, CcCallRequestModel>
    {
        public CallController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcCallReadModel>>>> GetAll([FromQuery]  CcCallRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcCallReadModel>>> GetOne(long id, [FromQuery] CcCallRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> {success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCallReadModel>> Add([FromBody]CcCallCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCallReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcCallReadModel>> Update(long id, CcCallUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcCallReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
        protected override IQueryable<CcCall> HandleRequest(CcCallRequestModel request)
        {
            var readModels = _dbContext.Set<CcCall>().AsNoTracking().Where(p =>
                (request.cardId == null || request.cardId == p.CardId) &&
                (request.terminateCauseId == null || request.terminateCauseId == p.Terminatecauseid) &&
                (request.phoneNumber == null || request.phoneNumber == p.Calledstation)
            ).OrderBy(x => x.Id);
            return readModels;
        }
    }
}