using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcStatusLogProfile
        : AutoMapper.Profile
    {
        public CcStatusLogProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcStatusLog, NesopsService.Domain.Models.CcStatusLogReadModel>();
            CreateMap<NesopsService.Domain.Models.CcStatusLogCreateModel, NesopsService.Data.Entities.CcStatusLog>();
            CreateMap<NesopsService.Data.Entities.CcStatusLog, NesopsService.Domain.Models.CcStatusLogUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcStatusLogUpdateModel, NesopsService.Data.Entities.CcStatusLog>();
        }

    }
}
