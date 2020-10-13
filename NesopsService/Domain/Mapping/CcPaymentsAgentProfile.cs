using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPaymentsAgentProfile
        : AutoMapper.Profile
    {
        public CcPaymentsAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPaymentsAgent, NesopsService.Domain.Models.CcPaymentsAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsAgentCreateModel, NesopsService.Data.Entities.CcPaymentsAgent>();
            CreateMap<NesopsService.Data.Entities.CcPaymentsAgent, NesopsService.Domain.Models.CcPaymentsAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsAgentUpdateModel, NesopsService.Data.Entities.CcPaymentsAgent>();
        }

    }
}
