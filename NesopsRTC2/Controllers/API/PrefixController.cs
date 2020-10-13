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
    public class PrefixController : ControllerBase
    {
        private Mya2billingContext _dbContext;
        private IMapper _mapper;
        public PrefixController(Mya2billingContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper; 
        }

        [HttpGet]
        [Authorize(Roles = "Administrator, Customer")]
        public async Task<ActionResult<BaseResponseModel<List<CcPrefixReadModel>>>> GetAll([FromQuery]  CcPrefixRequestModel requestModel, CancellationToken cancellationToken)
        {
            var query = _dbContext.Set<CcPrefix>().AsNoTracking();
            var readModel = _mapper.Map<List<CcPrefixReadModel>>((await query.ToListAsync(cancellationToken)));
            var result = new BaseResponseModel<List<CcPrefixReadModel>>
            {
                success = true,
                code = 200,
                data = readModel
            };
            return Ok(result);
        }
    }
}