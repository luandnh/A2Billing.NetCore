using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSubscriptionSignupProfile
        : AutoMapper.Profile
    {
        public CcSubscriptionSignupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSubscriptionSignup, NesopsService.Domain.Models.CcSubscriptionSignupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSubscriptionSignupCreateModel, NesopsService.Data.Entities.CcSubscriptionSignup>();
            CreateMap<NesopsService.Data.Entities.CcSubscriptionSignup, NesopsService.Domain.Models.CcSubscriptionSignupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSubscriptionSignupUpdateModel, NesopsService.Data.Entities.CcSubscriptionSignup>();
        }

    }
}
