using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAgentProfile
        : AutoMapper.Profile
    {
        public CcAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAgent, NesopsService.Domain.Models.CcAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentCreateModel, NesopsService.Data.Entities.CcAgent>();
            CreateMap<NesopsService.Data.Entities.CcAgent, NesopsService.Domain.Models.CcAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentUpdateModel, NesopsService.Data.Entities.CcAgent>();
        }

    }
}
