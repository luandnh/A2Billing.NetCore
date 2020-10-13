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
    public class TicketController : BaseEntityController<Mya2billingContext, CcTicket, CcTicketReadModel, CcTicketCreateModel, CcTicketUpdateModel, CcTicketRequestModel>
    {
        public TicketController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcTicketReadModel>>>> GetAll([FromQuery]  CcTicketRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcTicketReadModel>>> GetOne(long id, [FromQuery] CcTicketRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketReadModel>> Add([FromBody]CcTicketCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketReadModel>> Update(long id, CcTicketUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcTicketReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
        protected override IQueryable<CcTicket> HandleRequest(CcTicketRequestModel request)
        {
            var readModels = _dbContext.Set<CcTicket>().AsNoTracking().Where(p =>
                (request.cardId == null || request.cardId == p.Creator) &&
                (request.viewedAdmin == null || request.viewedAdmin == (p.ViewedAdmin == 0)) &&
                (request.viewedCust == null || request.viewedCust == (p.ViewedCust == 0)) &&
                (request.creatorType == null || request.creatorType == (p.ViewedCust == 0)) &&
                (request.status == null || request.status == p.Status)
            );
            return readModels;
        }
    }
}