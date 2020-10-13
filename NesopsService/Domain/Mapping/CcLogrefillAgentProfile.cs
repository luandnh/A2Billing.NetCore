using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcLogrefillAgentProfile
        : AutoMapper.Profile
    {
        public CcLogrefillAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcLogrefillAgent, NesopsService.Domain.Models.CcLogrefillAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcLogrefillAgentCreateModel, NesopsService.Data.Entities.CcLogrefillAgent>();
            CreateMap<NesopsService.Data.Entities.CcLogrefillAgent, NesopsService.Domain.Models.CcLogrefillAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcLogrefillAgentUpdateModel, NesopsService.Data.Entities.CcLogrefillAgent>();
        }

    }
}
