using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcEpaymentLogAgentProfile
        : AutoMapper.Profile
    {
        public CcEpaymentLogAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcEpaymentLogAgent, NesopsService.Domain.Models.CcEpaymentLogAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcEpaymentLogAgentCreateModel, NesopsService.Data.Entities.CcEpaymentLogAgent>();
            CreateMap<NesopsService.Data.Entities.CcEpaymentLogAgent, NesopsService.Domain.Models.CcEpaymentLogAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcEpaymentLogAgentUpdateModel, NesopsService.Data.Entities.CcEpaymentLogAgent>();
        }

    }
}
