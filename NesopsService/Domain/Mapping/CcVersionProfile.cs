using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcVersionProfile
        : AutoMapper.Profile
    {
        public CcVersionProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcVersion, NesopsService.Domain.Models.CcVersionReadModel>();
            CreateMap<NesopsService.Domain.Models.CcVersionCreateModel, NesopsService.Data.Entities.CcVersion>();
            CreateMap<NesopsService.Data.Entities.CcVersion, NesopsService.Domain.Models.CcVersionUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcVersionUpdateModel, NesopsService.Data.Entities.CcVersion>();
        }

    }
}
