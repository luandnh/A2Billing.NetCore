using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcReceiptItemProfile
        : AutoMapper.Profile
    {
        public CcReceiptItemProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcReceiptItem, NesopsService.Domain.Models.CcReceiptItemReadModel>();
            CreateMap<NesopsService.Domain.Models.CcReceiptItemCreateModel, NesopsService.Data.Entities.CcReceiptItem>();
            CreateMap<NesopsService.Data.Entities.CcReceiptItem, NesopsService.Domain.Models.CcReceiptItemUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcReceiptItemUpdateModel, NesopsService.Data.Entities.CcReceiptItem>();
        }

    }
}
