using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardPackageOfferProfile
        : AutoMapper.Profile
    {
        public CcCardPackageOfferProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardPackageOffer, NesopsService.Domain.Models.CcCardPackageOfferReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardPackageOfferCreateModel, NesopsService.Data.Entities.CcCardPackageOffer>();
            CreateMap<NesopsService.Data.Entities.CcCardPackageOffer, NesopsService.Domain.Models.CcCardPackageOfferUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardPackageOfferUpdateModel, NesopsService.Data.Entities.CcCardPackageOffer>();
        }

    }
}
