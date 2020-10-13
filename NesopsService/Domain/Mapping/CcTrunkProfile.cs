using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTrunkProfile
        : AutoMapper.Profile
    {
        public CcTrunkProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTrunk, NesopsService.Domain.Models.CcTrunkReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTrunkCreateModel, NesopsService.Data.Entities.CcTrunk>();
            CreateMap<NesopsService.Data.Entities.CcTrunk, NesopsService.Domain.Models.CcTrunkUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTrunkUpdateModel, NesopsService.Data.Entities.CcTrunk>();
        }

    }
}
