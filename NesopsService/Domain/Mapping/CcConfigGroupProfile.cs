using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcConfigGroupProfile
        : AutoMapper.Profile
    {
        public CcConfigGroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcConfigGroup, NesopsService.Domain.Models.CcConfigGroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigGroupCreateModel, NesopsService.Data.Entities.CcConfigGroup>();
            CreateMap<NesopsService.Data.Entities.CcConfigGroup, NesopsService.Domain.Models.CcConfigGroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcConfigGroupUpdateModel, NesopsService.Data.Entities.CcConfigGroup>();
        }

    }
}
