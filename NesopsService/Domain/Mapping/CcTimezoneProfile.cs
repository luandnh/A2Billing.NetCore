using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTimezoneProfile
        : AutoMapper.Profile
    {
        public CcTimezoneProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTimezone, NesopsService.Domain.Models.CcTimezoneReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTimezoneCreateModel, NesopsService.Data.Entities.CcTimezone>();
            CreateMap<NesopsService.Data.Entities.CcTimezone, NesopsService.Domain.Models.CcTimezoneUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTimezoneUpdateModel, NesopsService.Data.Entities.CcTimezone>();
        }

    }
}
