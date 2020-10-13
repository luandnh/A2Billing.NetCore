using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAlarmReportProfile
        : AutoMapper.Profile
    {
        public CcAlarmReportProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAlarmReport, NesopsService.Domain.Models.CcAlarmReportReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAlarmReportCreateModel, NesopsService.Data.Entities.CcAlarmReport>();
            CreateMap<NesopsService.Data.Entities.CcAlarmReport, NesopsService.Domain.Models.CcAlarmReportUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAlarmReportUpdateModel, NesopsService.Data.Entities.CcAlarmReport>();
        }

    }
}
