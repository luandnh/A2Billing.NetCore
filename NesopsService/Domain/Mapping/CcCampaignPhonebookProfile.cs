using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCampaignPhonebookProfile
        : AutoMapper.Profile
    {
        public CcCampaignPhonebookProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCampaignPhonebook, NesopsService.Domain.Models.CcCampaignPhonebookReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignPhonebookCreateModel, NesopsService.Data.Entities.CcCampaignPhonebook>();
            CreateMap<NesopsService.Data.Entities.CcCampaignPhonebook, NesopsService.Domain.Models.CcCampaignPhonebookUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignPhonebookUpdateModel, NesopsService.Data.Entities.CcCampaignPhonebook>();
        }

    }
}
