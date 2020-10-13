using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTariffgroupPlanProfile
        : AutoMapper.Profile
    {
        public CcTariffgroupPlanProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTariffgroupPlan, NesopsService.Domain.Models.CcTariffgroupPlanReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffgroupPlanCreateModel, NesopsService.Data.Entities.CcTariffgroupPlan>();
            CreateMap<NesopsService.Data.Entities.CcTariffgroupPlan, NesopsService.Domain.Models.CcTariffgroupPlanUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffgroupPlanUpdateModel, NesopsService.Data.Entities.CcTariffgroupPlan>();
        }

    }
}
