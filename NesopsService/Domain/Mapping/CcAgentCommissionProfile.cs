using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAgentCommissionProfile
        : AutoMapper.Profile
    {
        public CcAgentCommissionProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAgentCommission, NesopsService.Domain.Models.CcAgentCommissionReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentCommissionCreateModel, NesopsService.Data.Entities.CcAgentCommission>();
            CreateMap<NesopsService.Data.Entities.CcAgentCommission, NesopsService.Domain.Models.CcAgentCommissionUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentCommissionUpdateModel, NesopsService.Data.Entities.CcAgentCommission>();
        }

    }
}
