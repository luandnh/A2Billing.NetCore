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
    public class IaxBuddiesController : BaseEntityController<Mya2billingContext, CcIaxBuddies, CcIaxBuddiesReadModel, CcIaxBuddiesCreateModel, CcIaxBuddiesUpdateModel, CcIaxBuddiesRequestModel>
    {
        public IaxBuddiesController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcIaxBuddiesReadModel>>>> GetAll([FromQuery]  CcIaxBuddiesRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<CcIaxBuddiesReadModel>>> GetOne(long id, [FromQuery] CcIaxBuddiesRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcIaxBuddiesReadModel>> Add([FromBody]CcIaxBuddiesCreateModel createModel, CancellationToken cancellationToken)
        {
            var checkCard = _dbContext.Set<CcCard>().AsNoTracking().FirstOrDefault(p => p.Id == createModel.IdCcCard);
            if (checkCard == null)
            {
                return NotFound(new BaseResponseModel<object> { success = false, message = "Card Id Not found", code = 404 });
            }
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcIaxBuddiesReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<CcIaxBuddiesReadModel>> Update(long id, CcIaxBuddiesUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcIaxBuddiesReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
    }
}