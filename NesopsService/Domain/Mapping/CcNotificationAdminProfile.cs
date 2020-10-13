using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcNotificationAdminProfile
        : AutoMapper.Profile
    {
        public CcNotificationAdminProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcNotificationAdmin, NesopsService.Domain.Models.CcNotificationAdminReadModel>();
            CreateMap<NesopsService.Domain.Models.CcNotificationAdminCreateModel, NesopsService.Data.Entities.CcNotificationAdmin>();
            CreateMap<NesopsService.Data.Entities.CcNotificationAdmin, NesopsService.Domain.Models.CcNotificationAdminUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcNotificationAdminUpdateModel, NesopsService.Data.Entities.CcNotificationAdmin>();
        }

    }
}
