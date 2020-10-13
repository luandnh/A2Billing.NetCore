using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAlarmProfile
        : AutoMapper.Profile
    {
        public CcAlarmProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAlarm, NesopsService.Domain.Models.CcAlarmReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAlarmCreateModel, NesopsService.Data.Entities.CcAlarm>();
            CreateMap<NesopsService.Data.Entities.CcAlarm, NesopsService.Domain.Models.CcAlarmUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAlarmUpdateModel, NesopsService.Data.Entities.CcAlarm>();
        }

    }
}
