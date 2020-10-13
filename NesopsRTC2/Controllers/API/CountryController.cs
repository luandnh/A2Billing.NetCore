using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class CountryController : BaseEntityController<Mya2billingContext, CcCountry, CcCountryReadModel, CcCountryCreateModel, CcCountryUpdateModel, CcCountryRequestModel>
    {
        public CountryController(Mya2billingContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcCountryReadModel>>>> GetAll([FromQuery]  CcCountryRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModels = await ListModel(requestModel, cancellationToken);
            return Ok(readModels);
        }
#if Debug
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GetResponseModel<CcCountryReadModel, CcCountryRequestModel>>> GetOne(long id, [FromQuery] CcCountryRequestModel requestModel, CancellationToken cancellationToken)
        {
            var readModel = await ReadModel(id, requestModel, cancellationToken);
            if (readModel == null)
                return NotFound(new BaseResponseModel<object> { message = "Not found", code = 404 });
            return Ok(readModel);
        }
        [HttpPost]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcCountryReadModel>> Add([FromBody]CcCountryCreateModel createModel, CancellationToken cancellationToken)
        {
            var readModel = await CreateModel(createModel, cancellationToken);
            return CreatedAtAction(nameof(GetOne), new { id = readModel.Id }, readModel);
        }
        [HttpDelete]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcCountryReadModel>> Delete(long id, CancellationToken cancellationToken)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            return Ok(new BaseResponseModel<object> { message = "Delete Successful", code = 404 });
        }
        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Web Application")]
        public async Task<ActionResult<CcCountryReadModel>> Update(long id, CcCountryUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            return Ok(new BaseResponseModel<CcCountryReadModel> { message = "Update Successful", data = readModel, code = 404 });
        }
#endif

    }
}