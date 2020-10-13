using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCallProfile
        : AutoMapper.Profile
    {
        public CcCallProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCall, NesopsService.Domain.Models.CcCallReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCallCreateModel, NesopsService.Data.Entities.CcCall>();
            CreateMap<NesopsService.Data.Entities.CcCall, NesopsService.Domain.Models.CcCallUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCallUpdateModel, NesopsService.Data.Entities.CcCall>();
        }

    }
}
