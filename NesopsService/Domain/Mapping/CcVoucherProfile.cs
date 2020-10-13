using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcVoucherProfile
        : AutoMapper.Profile
    {
        public CcVoucherProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcVoucher, NesopsService.Domain.Models.CcVoucherReadModel>();
            CreateMap<NesopsService.Domain.Models.CcVoucherCreateModel, NesopsService.Data.Entities.CcVoucher>();
            CreateMap<NesopsService.Data.Entities.CcVoucher, NesopsService.Domain.Models.CcVoucherUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcVoucherUpdateModel, NesopsService.Data.Entities.CcVoucher>();
        }

    }
}
