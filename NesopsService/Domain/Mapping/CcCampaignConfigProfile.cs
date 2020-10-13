using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCampaignConfigProfile
        : AutoMapper.Profile
    {
        public CcCampaignConfigProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCampaignConfig, NesopsService.Domain.Models.CcCampaignConfigReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignConfigCreateModel, NesopsService.Data.Entities.CcCampaignConfig>();
            CreateMap<NesopsService.Data.Entities.CcCampaignConfig, NesopsService.Domain.Models.CcCampaignConfigUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignConfigUpdateModel, NesopsService.Data.Entities.CcCampaignConfig>();
        }

    }
}
