using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPaymentMethodsProfile
        : AutoMapper.Profile
    {
        public CcPaymentMethodsProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPaymentMethods, NesopsService.Domain.Models.CcPaymentMethodsReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentMethodsCreateModel, NesopsService.Data.Entities.CcPaymentMethods>();
            CreateMap<NesopsService.Data.Entities.CcPaymentMethods, NesopsService.Domain.Models.CcPaymentMethodsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentMethodsUpdateModel, NesopsService.Data.Entities.CcPaymentMethods>();
        }

    }
}
