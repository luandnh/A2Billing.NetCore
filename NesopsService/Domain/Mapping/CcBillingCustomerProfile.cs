using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcBillingCustomerProfile
        : AutoMapper.Profile
    {
        public CcBillingCustomerProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcBillingCustomer, NesopsService.Domain.Models.CcBillingCustomerReadModel>();
            CreateMap<NesopsService.Domain.Models.CcBillingCustomerCreateModel, NesopsService.Data.Entities.CcBillingCustomer>();
            CreateMap<NesopsService.Data.Entities.CcBillingCustomer, NesopsService.Domain.Models.CcBillingCustomerUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcBillingCustomerUpdateModel, NesopsService.Data.Entities.CcBillingCustomer>();
        }

    }
}
