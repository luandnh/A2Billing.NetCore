using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSupportProfile
        : AutoMapper.Profile
    {
        public CcSupportProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSupport, NesopsService.Domain.Models.CcSupportReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSupportCreateModel, NesopsService.Data.Entities.CcSupport>();
            CreateMap<NesopsService.Data.Entities.CcSupport, NesopsService.Domain.Models.CcSupportUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSupportUpdateModel, NesopsService.Data.Entities.CcSupport>();
        }

    }
}
