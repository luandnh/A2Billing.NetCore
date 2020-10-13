using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcReceiptProfile
        : AutoMapper.Profile
    {
        public CcReceiptProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcReceipt, NesopsService.Domain.Models.CcReceiptReadModel>();
            CreateMap<NesopsService.Domain.Models.CcReceiptCreateModel, NesopsService.Data.Entities.CcReceipt>();
            CreateMap<NesopsService.Data.Entities.CcReceipt, NesopsService.Domain.Models.CcReceiptUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcReceiptUpdateModel, NesopsService.Data.Entities.CcReceipt>();
        }

    }
}
