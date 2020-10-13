using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPackageGroupProfile
        : AutoMapper.Profile
    {
        public CcPackageGroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPackageGroup, NesopsService.Domain.Models.CcPackageGroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageGroupCreateModel, NesopsService.Data.Entities.CcPackageGroup>();
            CreateMap<NesopsService.Data.Entities.CcPackageGroup, NesopsService.Domain.Models.CcPackageGroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageGroupUpdateModel, NesopsService.Data.Entities.CcPackageGroup>();
        }

    }
}
