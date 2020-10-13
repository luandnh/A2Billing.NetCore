using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcDidUseProfile
        : AutoMapper.Profile
    {
        public CcDidUseProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcDidUse, NesopsService.Domain.Models.CcDidUseReadModel>();
            CreateMap<NesopsService.Domain.Models.CcDidUseCreateModel, NesopsService.Data.Entities.CcDidUse>();
            CreateMap<NesopsService.Data.Entities.CcDidUse, NesopsService.Domain.Models.CcDidUseUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcDidUseUpdateModel, NesopsService.Data.Entities.CcDidUse>();
        }

    }
}
