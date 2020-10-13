using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCampaignProfile
        : AutoMapper.Profile
    {
        public CcCampaignProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCampaign, NesopsService.Domain.Models.CcCampaignReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignCreateModel, NesopsService.Data.Entities.CcCampaign>();
            CreateMap<NesopsService.Data.Entities.CcCampaign, NesopsService.Domain.Models.CcCampaignUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignUpdateModel, NesopsService.Data.Entities.CcCampaign>();
        }

    }
}
