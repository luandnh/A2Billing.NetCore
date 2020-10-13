using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPackgroupPackageProfile
        : AutoMapper.Profile
    {
        public CcPackgroupPackageProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPackgroupPackage, NesopsService.Domain.Models.CcPackgroupPackageReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPackgroupPackageCreateModel, NesopsService.Data.Entities.CcPackgroupPackage>();
            CreateMap<NesopsService.Data.Entities.CcPackgroupPackage, NesopsService.Domain.Models.CcPackgroupPackageUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPackgroupPackageUpdateModel, NesopsService.Data.Entities.CcPackgroupPackage>();
        }

    }
}
