using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcInvoiceProfile
        : AutoMapper.Profile
    {
        public CcInvoiceProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcInvoice, NesopsService.Domain.Models.CcInvoiceReadModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceCreateModel, NesopsService.Data.Entities.CcInvoice>();
            CreateMap<NesopsService.Data.Entities.CcInvoice, NesopsService.Domain.Models.CcInvoiceUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceUpdateModel, NesopsService.Data.Entities.CcInvoice>();
        }

    }
}
