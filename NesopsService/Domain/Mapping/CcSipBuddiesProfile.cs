using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSipBuddiesProfile
        : AutoMapper.Profile
    {
        public CcSipBuddiesProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSipBuddies, NesopsService.Domain.Models.CcSipBuddiesReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSipBuddiesCreateModel, NesopsService.Data.Entities.CcSipBuddies>();
            CreateMap<NesopsService.Data.Entities.CcSipBuddies, NesopsService.Domain.Models.CcSipBuddiesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSipBuddiesUpdateModel, NesopsService.Data.Entities.CcSipBuddies>();
        }

    }
}
