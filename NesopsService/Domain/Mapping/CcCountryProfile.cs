using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCountryProfile
        : AutoMapper.Profile
    {
        public CcCountryProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCountry, NesopsService.Domain.Models.CcCountryReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCountryCreateModel, NesopsService.Data.Entities.CcCountry>();
            CreateMap<NesopsService.Data.Entities.CcCountry, NesopsService.Domain.Models.CcCountryUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCountryUpdateModel, NesopsService.Data.Entities.CcCountry>();
        }

    }
}
