using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSipBuddiesEmptyProfile
        : AutoMapper.Profile
    {
        public CcSipBuddiesEmptyProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSipBuddiesEmpty, NesopsService.Domain.Models.CcSipBuddiesEmptyReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSipBuddiesEmptyCreateModel, NesopsService.Data.Entities.CcSipBuddiesEmpty>();
            CreateMap<NesopsService.Data.Entities.CcSipBuddiesEmpty, NesopsService.Domain.Models.CcSipBuddiesEmptyUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSipBuddiesEmptyUpdateModel, NesopsService.Data.Entities.CcSipBuddiesEmpty>();
        }

    }
}
