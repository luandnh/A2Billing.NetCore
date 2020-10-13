using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAgentTariffgroupProfile
        : AutoMapper.Profile
    {
        public CcAgentTariffgroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAgentTariffgroup, NesopsService.Domain.Models.CcAgentTariffgroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentTariffgroupCreateModel, NesopsService.Data.Entities.CcAgentTariffgroup>();
            CreateMap<NesopsService.Data.Entities.CcAgentTariffgroup, NesopsService.Domain.Models.CcAgentTariffgroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAgentTariffgroupUpdateModel, NesopsService.Data.Entities.CcAgentTariffgroup>();
        }

    }
}
