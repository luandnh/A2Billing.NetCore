using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTariffgroupProfile
        : AutoMapper.Profile
    {
        public CcTariffgroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTariffgroup, NesopsService.Domain.Models.CcTariffgroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffgroupCreateModel, NesopsService.Data.Entities.CcTariffgroup>();
            CreateMap<NesopsService.Data.Entities.CcTariffgroup, NesopsService.Domain.Models.CcTariffgroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffgroupUpdateModel, NesopsService.Data.Entities.CcTariffgroup>();
        }

    }
}
