using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCallplanLcrProfile
        : AutoMapper.Profile
    {
        public CcCallplanLcrProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCallplanLcr, NesopsService.Domain.Models.CcCallplanLcrReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCallplanLcrCreateModel, NesopsService.Data.Entities.CcCallplanLcr>();
            CreateMap<NesopsService.Data.Entities.CcCallplanLcr, NesopsService.Domain.Models.CcCallplanLcrUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCallplanLcrUpdateModel, NesopsService.Data.Entities.CcCallplanLcr>();
        }

    }
}
