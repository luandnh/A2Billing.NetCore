using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcConfigProfile
        : AutoMapper.Profile
    {
        public CcConfigProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcConfig, NesopsService.Domain.Models.CcConfigReadModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigCreateModel, NesopsService.Data.Entities.CcConfig>();
            CreateMap<NesopsService.Data.Entities.CcConfig, NesopsService.Domain.Models.CcConfigUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigUpdateModel, NesopsService.Data.Entities.CcConfig>();
        }

    }
}
