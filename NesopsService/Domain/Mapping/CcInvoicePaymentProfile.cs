using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcInvoicePaymentProfile
        : AutoMapper.Profile
    {
        public CcInvoicePaymentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcInvoicePayment, NesopsService.Domain.Models.CcInvoicePaymentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoicePaymentCreateModel, NesopsService.Data.Entities.CcInvoicePayment>();
            CreateMap<NesopsService.Data.Entities.CcInvoicePayment, NesopsService.Domain.Models.CcInvoicePaymentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoicePaymentUpdateModel, NesopsService.Data.Entities.CcInvoicePayment>();
        }

    }
}
