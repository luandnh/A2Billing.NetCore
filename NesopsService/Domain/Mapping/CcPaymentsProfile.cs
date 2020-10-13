using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPaymentsProfile
        : AutoMapper.Profile
    {
        public CcPaymentsProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPayments, NesopsService.Domain.Models.CcPaymentsReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsCreateModel, NesopsService.Data.Entities.CcPayments>();
            CreateMap<NesopsService.Data.Entities.CcPayments, NesopsService.Domain.Models.CcPaymentsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsUpdateModel, NesopsService.Data.Entities.CcPayments>();
        }

    }
}
