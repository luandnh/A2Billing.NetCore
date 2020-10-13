using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcIaxBuddiesProfile
        : AutoMapper.Profile
    {
        public CcIaxBuddiesProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcIaxBuddies, NesopsService.Domain.Models.CcIaxBuddiesReadModel>();
            CreateMap<NesopsService.Domain.Models.CcIaxBuddiesCreateModel, NesopsService.Data.Entities.CcIaxBuddies>();
            CreateMap<NesopsService.Data.Entities.CcIaxBuddies, NesopsService.Domain.Models.CcIaxBuddiesUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcIaxBuddiesUpdateModel, NesopsService.Data.Entities.CcIaxBuddies>();
        }

    }
}
