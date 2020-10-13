using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcProviderProfile
        : AutoMapper.Profile
    {
        public CcProviderProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcProvider, NesopsService.Domain.Models.CcProviderReadModel>();
            CreateMap<NesopsService.Domain.Models.CcProviderCreateModel, NesopsService.Data.Entities.CcProvider>();
            CreateMap<NesopsService.Data.Entities.CcProvider, NesopsService.Domain.Models.CcProviderUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcProviderUpdateModel, NesopsService.Data.Entities.CcProvider>();
        }

    }
}
