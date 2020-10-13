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
    public class VoucherController : BaseEntityController<Mya2billingContext, CcVoucher, CcVoucherReadModel, CcVoucherCreateModel, CcVoucherUpdateModel, CcVoucherRequestModel>
    {
        public VoucherController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcVoucherReadModel>>>> GetAll([FromQuery]  CcVoucherRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcVoucherReadModel>>>> GetOne(long id, [FromQuery] CcVoucherRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { success = false, message = "Not found", code = 404 });
            return Ok(readModel);
        }
#if Debug
        [HttpPost]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcVoucherReadModel>> Add([FromBody]CcVoucherCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcVoucherReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcVoucherReadModel>> Update(long id, CcVoucherUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcVoucherReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
#endif
        protected override IQueryable<CcVoucher> HandleRequest(CcVoucherRequestModel request)
        {
            var readModels = _dbContext.Set<CcVoucher>().AsNoTracking().Where(p =>
                (request.usedcardnumber == null || request.usedcardnumber == p.Usedcardnumber)
                && (request.activated == null || request.activated == (p.Activated == "t"))
            );
            return readModels;
        }
    }
}