using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPaymentsStatusProfile
        : AutoMapper.Profile
    {
        public CcPaymentsStatusProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPaymentsStatus, NesopsService.Domain.Models.CcPaymentsStatusReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsStatusCreateModel, NesopsService.Data.Entities.CcPaymentsStatus>();
            CreateMap<NesopsService.Data.Entities.CcPaymentsStatus, NesopsService.Domain.Models.CcPaymentsStatusUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPaymentsStatusUpdateModel, NesopsService.Data.Entities.CcPaymentsStatus>();
        }

    }
}
