using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcMonitorProfile
        : AutoMapper.Profile
    {
        public CcMonitorProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcMonitor, NesopsService.Domain.Models.CcMonitorReadModel>();
            CreateMap<NesopsService.Domain.Models.CcMonitorCreateModel, NesopsService.Data.Entities.CcMonitor>();
            CreateMap<NesopsService.Data.Entities.CcMonitor, NesopsService.Domain.Models.CcMonitorUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcMonitorUpdateModel, NesopsService.Data.Entities.CcMonitor>();
        }

    }
}
