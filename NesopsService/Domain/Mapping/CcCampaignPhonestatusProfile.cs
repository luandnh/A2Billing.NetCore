using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCampaignPhonestatusProfile
        : AutoMapper.Profile
    {
        public CcCampaignPhonestatusProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCampaignPhonestatus, NesopsService.Domain.Models.CcCampaignPhonestatusReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignPhonestatusCreateModel, NesopsService.Data.Entities.CcCampaignPhonestatus>();
            CreateMap<NesopsService.Data.Entities.CcCampaignPhonestatus, NesopsService.Domain.Models.CcCampaignPhonestatusUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCampaignPhonestatusUpdateModel, NesopsService.Data.Entities.CcCampaignPhonestatus>();
        }

    }
}
