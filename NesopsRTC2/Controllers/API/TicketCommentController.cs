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
    public class TicketCommentController : BaseEntityController<Mya2billingContext, CcTicketComment, CcTicketCommentReadModel, CcTicketCommentCreateModel, CcTicketCommentUpdateModel, CcTicketCommentRequestModel>
    {
        public TicketCommentController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcTicketCommentReadModel>>>> GetAll([FromQuery]  CcTicketCommentRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcTicketCommentReadModel>>> GetOne(long id, [FromQuery] CcTicketCommentRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketCommentReadModel>> Add([FromBody]CcTicketCommentCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketCommentReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcTicketCommentReadModel>> Update(long id, CcTicketCommentUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcTicketCommentReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
        protected override IQueryable<CcTicketComment> HandleRequest(CcTicketCommentRequestModel request)
        {
            var readModels = _dbContext.Set<CcTicketComment>().AsNoTracking().Where(p =>
                (request.cardId == null || request.cardId == p.Creator) &&
                (request.ticketId == null || request.ticketId == p.IdTicket) &&
                (request.viewedAdmin == null || request.viewedAdmin == (p.ViewedAdmin == 0)) &&
                (request.viewedCust == null || request.viewedCust == (p.ViewedCust == 0))
            );
            return readModels;
        }
    }
}