using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcInvoiceConfProfile
        : AutoMapper.Profile
    {
        public CcInvoiceConfProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcInvoiceConf, NesopsService.Domain.Models.CcInvoiceConfReadModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceConfCreateModel, NesopsService.Data.Entities.CcInvoiceConf>();
            CreateMap<NesopsService.Data.Entities.CcInvoiceConf, NesopsService.Domain.Models.CcInvoiceConfUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcInvoiceConfUpdateModel, NesopsService.Data.Entities.CcInvoiceConf>();
        }

    }
}
