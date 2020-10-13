using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcDidDestinationProfile
        : AutoMapper.Profile
    {
        public CcDidDestinationProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcDidDestination, NesopsService.Domain.Models.CcDidDestinationReadModel>();
            CreateMap<NesopsService.Domain.Models.CcDidDestinationCreateModel, NesopsService.Data.Entities.CcDidDestination>();
            CreateMap<NesopsService.Data.Entities.CcDidDestination, NesopsService.Domain.Models.CcDidDestinationUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcDidDestinationUpdateModel, NesopsService.Data.Entities.CcDidDestination>();
        }

    }
}
