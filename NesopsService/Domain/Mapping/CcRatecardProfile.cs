using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcRatecardProfile
        : AutoMapper.Profile
    {
        public CcRatecardProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcRatecard, NesopsService.Domain.Models.CcRatecardReadModel>();
            CreateMap<NesopsService.Domain.Models.CcRatecardCreateModel, NesopsService.Data.Entities.CcRatecard>();
            CreateMap<NesopsService.Data.Entities.CcRatecard, NesopsService.Domain.Models.CcRatecardUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcRatecardUpdateModel, NesopsService.Data.Entities.CcRatecard>();
        }

    }
}
