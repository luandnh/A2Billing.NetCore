using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcMessageAgentProfile
        : AutoMapper.Profile
    {
        public CcMessageAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcMessageAgent, NesopsService.Domain.Models.CcMessageAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcMessageAgentCreateModel, NesopsService.Data.Entities.CcMessageAgent>();
            CreateMap<NesopsService.Data.Entities.CcMessageAgent, NesopsService.Domain.Models.CcMessageAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcMessageAgentUpdateModel, NesopsService.Data.Entities.CcMessageAgent>();
        }

    }
}
