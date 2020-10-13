using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSupportComponentProfile
        : AutoMapper.Profile
    {
        public CcSupportComponentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSupportComponent, NesopsService.Domain.Models.CcSupportComponentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSupportComponentCreateModel, NesopsService.Data.Entities.CcSupportComponent>();
            CreateMap<NesopsService.Data.Entities.CcSupportComponent, NesopsService.Domain.Models.CcSupportComponentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSupportComponentUpdateModel, NesopsService.Data.Entities.CcSupportComponent>();
        }

    }
}
