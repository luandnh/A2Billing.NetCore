using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcLogpaymentProfile
        : AutoMapper.Profile
    {
        public CcLogpaymentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcLogpayment, NesopsService.Domain.Models.CcLogpaymentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcLogpaymentCreateModel, NesopsService.Data.Entities.CcLogpayment>();
            CreateMap<NesopsService.Data.Entities.CcLogpayment, NesopsService.Domain.Models.CcLogpaymentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcLogpaymentUpdateModel, NesopsService.Data.Entities.CcLogpayment>();
        }

    }
}
