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
    public class LogRefillController : BaseEntityController<Mya2billingContext, CcLogrefill, CcLogrefillReadModel, CcLogrefillCreateModel, CcLogrefillUpdateModel, CcLogrefillRequestModel>
    {
        public LogRefillController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcLogrefillReadModel>>>> GetAll([FromQuery]  CcLogrefillRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }
#if Debug
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GetResponseModel<CcLogrefillReadModel, CcLogrefillRequestModel>>> GetOne(long id, [FromQuery] CcLogrefillRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcLogrefillReadModel>> Add([FromBody]CcLogrefillCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcLogrefillReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcLogrefillReadModel>> Update(long id, CcLogrefillUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcLogrefillReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
#endif
        protected override IQueryable<CcLogrefill> HandleRequest(CcLogrefillRequestModel request)
        {
            var readModels = _dbContext.Set<CcLogrefill>().AsNoTracking().Where(p =>
                (request.cardId == null || request.cardId == p.CardId)
            );
            return readModels;
        }
    }
}