using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcNotificationProfile
        : AutoMapper.Profile
    {
        public CcNotificationProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcNotification, NesopsService.Domain.Models.CcNotificationReadModel>();
            CreateMap<NesopsService.Domain.Models.CcNotificationCreateModel, NesopsService.Data.Entities.CcNotification>();
            CreateMap<NesopsService.Data.Entities.CcNotification, NesopsService.Domain.Models.CcNotificationUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcNotificationUpdateModel, NesopsService.Data.Entities.CcNotification>();
        }

    }
}
