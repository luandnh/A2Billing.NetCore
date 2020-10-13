using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPackageOfferProfile
        : AutoMapper.Profile
    {
        public CcPackageOfferProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPackageOffer, NesopsService.Domain.Models.CcPackageOfferReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageOfferCreateModel, NesopsService.Data.Entities.CcPackageOffer>();
            CreateMap<NesopsService.Data.Entities.CcPackageOffer, NesopsService.Domain.Models.CcPackageOfferUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPackageOfferUpdateModel, NesopsService.Data.Entities.CcPackageOffer>();
        }

    }
}
