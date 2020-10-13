using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcConfigurationProfile
        : AutoMapper.Profile
    {
        public CcConfigurationProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcConfiguration, NesopsService.Domain.Models.CcConfigurationReadModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigurationCreateModel, NesopsService.Data.Entities.CcConfiguration>();
            CreateMap<NesopsService.Data.Entities.CcConfiguration, NesopsService.Domain.Models.CcConfigurationUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigurationUpdateModel, NesopsService.Data.Entities.CcConfiguration>();
        }

    }
}
