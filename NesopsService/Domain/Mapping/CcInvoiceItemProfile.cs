using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcInvoiceItemProfile
        : AutoMapper.Profile
    {
        public CcInvoiceItemProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcInvoiceItem, NesopsService.Domain.Models.CcInvoiceItemReadModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceItemCreateModel, NesopsService.Data.Entities.CcInvoiceItem>();
            CreateMap<NesopsService.Data.Entities.CcInvoiceItem, NesopsService.Domain.Models.CcInvoiceItemUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceItemUpdateModel, NesopsService.Data.Entities.CcInvoiceItem>();
        }

    }
}
