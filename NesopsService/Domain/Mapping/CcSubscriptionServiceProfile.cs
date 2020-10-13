using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSubscriptionServiceProfile
        : AutoMapper.Profile
    {
        public CcSubscriptionServiceProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSubscriptionService, NesopsService.Domain.Models.CcSubscriptionServiceReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSubscriptionServiceCreateModel, NesopsService.Data.Entities.CcSubscriptionService>();
            CreateMap<NesopsService.Data.Entities.CcSubscriptionService, NesopsService.Domain.Models.CcSubscriptionServiceUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSubscriptionServiceUpdateModel, NesopsService.Data.Entities.CcSubscriptionService>();
        }

    }
}
