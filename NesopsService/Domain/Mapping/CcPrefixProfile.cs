using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPrefixProfile
        : AutoMapper.Profile
    {
        public CcPrefixProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPrefix, NesopsService.Domain.Models.CcPrefixReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPrefixCreateModel, NesopsService.Data.Entities.CcPrefix>();
            CreateMap<NesopsService.Data.Entities.CcPrefix, NesopsService.Domain.Models.CcPrefixUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPrefixUpdateModel, NesopsService.Data.Entities.CcPrefix>();
        }

    }
}
