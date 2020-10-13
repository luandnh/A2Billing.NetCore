using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcChargeProfile
        : AutoMapper.Profile
    {
        public CcChargeProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCharge, NesopsService.Domain.Models.CcChargeReadModel>();
            CreateMap<NesopsService.Domain.Models.CcChargeCreateModel, NesopsService.Data.Entities.CcCharge>();
            CreateMap<NesopsService.Data.Entities.CcCharge, NesopsService.Domain.Models.CcChargeUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcChargeUpdateModel, NesopsService.Data.Entities.CcCharge>();
        }

    }
}
