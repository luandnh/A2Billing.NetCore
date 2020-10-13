using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcDidgroupProfile
        : AutoMapper.Profile
    {
        public CcDidgroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcDidgroup, NesopsService.Domain.Models.CcDidgroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcDidgroupCreateModel, NesopsService.Data.Entities.CcDidgroup>();
            CreateMap<NesopsService.Data.Entities.CcDidgroup, NesopsService.Domain.Models.CcDidgroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcDidgroupUpdateModel, NesopsService.Data.Entities.CcDidgroup>();
        }

    }
}
