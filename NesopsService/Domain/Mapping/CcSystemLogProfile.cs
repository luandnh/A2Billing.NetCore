using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSystemLogProfile
        : AutoMapper.Profile
    {
        public CcSystemLogProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSystemLog, NesopsService.Domain.Models.CcSystemLogReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSystemLogCreateModel, NesopsService.Data.Entities.CcSystemLog>();
            CreateMap<NesopsService.Data.Entities.CcSystemLog, NesopsService.Domain.Models.CcSystemLogUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSystemLogUpdateModel, NesopsService.Data.Entities.CcSystemLog>();
        }

    }
}
