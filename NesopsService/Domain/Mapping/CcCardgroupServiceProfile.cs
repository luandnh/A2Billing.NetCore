using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardgroupServiceProfile
        : AutoMapper.Profile
    {
        public CcCardgroupServiceProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardgroupService, NesopsService.Domain.Models.CcCardgroupServiceReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardgroupServiceCreateModel, NesopsService.Data.Entities.CcCardgroupService>();
            CreateMap<NesopsService.Data.Entities.CcCardgroupService, NesopsService.Domain.Models.CcCardgroupServiceUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardgroupServiceUpdateModel, NesopsService.Data.Entities.CcCardgroupService>();
        }

    }
}
