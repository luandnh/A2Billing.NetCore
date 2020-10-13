using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAgentSignupProfile
        : AutoMapper.Profile
    {
        public CcAgentSignupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAgentSignup, NesopsService.Domain.Models.CcAgentSignupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentSignupCreateModel, NesopsService.Data.Entities.CcAgentSignup>();
            CreateMap<NesopsService.Data.Entities.CcAgentSignup, NesopsService.Domain.Models.CcAgentSignupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentSignupUpdateModel, NesopsService.Data.Entities.CcAgentSignup>();
        }

    }
}
