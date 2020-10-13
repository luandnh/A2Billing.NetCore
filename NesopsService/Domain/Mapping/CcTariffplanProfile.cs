using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTariffplanProfile
        : AutoMapper.Profile
    {
        public CcTariffplanProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTariffplan, NesopsService.Domain.Models.CcTariffplanReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffplanCreateModel, NesopsService.Data.Entities.CcTariffplan>();
            CreateMap<NesopsService.Data.Entities.CcTariffplan, NesopsService.Domain.Models.CcTariffplanUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTariffplanUpdateModel, NesopsService.Data.Entities.CcTariffplan>();
        }

    }
}
