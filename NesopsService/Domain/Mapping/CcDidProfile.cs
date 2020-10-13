using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcDidProfile
        : AutoMapper.Profile
    {
        public CcDidProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcDid, NesopsService.Domain.Models.CcDidReadModel>();
            CreateMap<NesopsService.Domain.Models.CcDidCreateModel, NesopsService.Data.Entities.CcDid>();
            CreateMap<NesopsService.Data.Entities.CcDid, NesopsService.Domain.Models.CcDidUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcDidUpdateModel, NesopsService.Data.Entities.CcDid>();
        }

    }
}
