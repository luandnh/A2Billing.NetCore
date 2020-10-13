using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcEpaymentLogProfile
        : AutoMapper.Profile
    {
        public CcEpaymentLogProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcEpaymentLog, NesopsService.Domain.Models.CcEpaymentLogReadModel>();
            CreateMap<NesopsService.Domain.Models.CcEpaymentLogCreateModel, NesopsService.Data.Entities.CcEpaymentLog>();
            CreateMap<NesopsService.Data.Entities.CcEpaymentLog, NesopsService.Domain.Models.CcEpaymentLogUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcEpaymentLogUpdateModel, NesopsService.Data.Entities.CcEpaymentLog>();
        }

    }
}
