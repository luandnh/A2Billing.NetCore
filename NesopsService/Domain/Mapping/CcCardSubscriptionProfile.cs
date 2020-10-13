using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardSubscriptionProfile
        : AutoMapper.Profile
    {
        public CcCardSubscriptionProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardSubscription, NesopsService.Domain.Models.CcCardSubscriptionReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardSubscriptionCreateModel, NesopsService.Data.Entities.CcCardSubscription>();
            CreateMap<NesopsService.Data.Entities.CcCardSubscription, NesopsService.Domain.Models.CcCardSubscriptionUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardSubscriptionUpdateModel, NesopsService.Data.Entities.CcCardSubscription>();
        }

    }
}
