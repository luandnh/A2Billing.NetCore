using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcLogpaymentAgentProfile
        : AutoMapper.Profile
    {
        public CcLogpaymentAgentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcLogpaymentAgent, NesopsService.Domain.Models.CcLogpaymentAgentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcLogpaymentAgentCreateModel, NesopsService.Data.Entities.CcLogpaymentAgent>();
            CreateMap<NesopsService.Data.Entities.CcLogpaymentAgent, NesopsService.Domain.Models.CcLogpaymentAgentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcLogpaymentAgentUpdateModel, NesopsService.Data.Entities.CcLogpaymentAgent>();
        }

    }
}
