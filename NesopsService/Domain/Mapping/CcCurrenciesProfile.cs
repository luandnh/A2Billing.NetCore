using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCurrenciesProfile
        : AutoMapper.Profile
    {
        public CcCurrenciesProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCurrencies, NesopsService.Domain.Models.CcCurrenciesReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCurrenciesCreateModel, NesopsService.Data.Entities.CcCurrencies>();
            CreateMap<NesopsService.Data.Entities.CcCurrencies, NesopsService.Domain.Models.CcCurrenciesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCurrenciesUpdateModel, NesopsService.Data.Entities.CcCurrencies>();
        }

    }
}
