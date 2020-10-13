using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCampaignconfCardgroupProfile
        : AutoMapper.Profile
    {
        public CcCampaignconfCardgroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCampaignconfCardgroup, NesopsService.Domain.Models.CcCampaignconfCardgroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignconfCardgroupCreateModel, NesopsService.Data.Entities.CcCampaignconfCardgroup>();
            CreateMap<NesopsService.Data.Entities.CcCampaignconfCardgroup, NesopsService.Domain.Models.CcCampaignconfCardgroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignconfCardgroupUpdateModel, NesopsService.Data.Entities.CcCampaignconfCardgroup>();
        }

    }
}
