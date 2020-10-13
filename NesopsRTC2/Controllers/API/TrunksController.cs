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
using NesopsService.Base.Model;
using NesopsService.Data;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;
using NesopsService.Models.RequestModels;

namespace NesopsRTC2.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrunksController : ControllerBase
    {
        private Mya2billingContext _dbContext;
        private IMapper _mapper;
        public TrunksController(Mya2billingContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper; 
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcTrunkReadModel>>>> GetAll([FromQuery]  CcTrunkRequestModel requestModel, CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<CcTrunk>().AsNoTracking();
            var readModel = _mapper.Map<List<CcTrunkReadModel>>((await query.ToListAsync(cancellationToken)));
            var result = new BaseResponseModel<List<CcTrunkReadModel>>
            {
                success = true,
                code = 200,
                data = readModel
            };
            return Ok(result);
        }
    }
}