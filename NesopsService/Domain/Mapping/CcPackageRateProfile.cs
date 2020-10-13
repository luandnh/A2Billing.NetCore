using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPackageRateProfile
        : AutoMapper.Profile
    {
        public CcPackageRateProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPackageRate, NesopsService.Domain.Models.CcPackageRateReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageRateCreateModel, NesopsService.Data.Entities.CcPackageRate>();
            CreateMap<NesopsService.Data.Entities.CcPackageRate, NesopsService.Domain.Models.CcPackageRateUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageRateUpdateModel, NesopsService.Data.Entities.CcPackageRate>();
        }

    }
}
