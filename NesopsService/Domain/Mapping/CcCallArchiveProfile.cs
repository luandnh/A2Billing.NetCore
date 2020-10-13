using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCallArchiveProfile
        : AutoMapper.Profile
    {
        public CcCallArchiveProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCallArchive, NesopsService.Domain.Models.CcCallArchiveReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCallArchiveCreateModel, NesopsService.Data.Entities.CcCallArchive>();
            CreateMap<NesopsService.Data.Entities.CcCallArchive, NesopsService.Domain.Models.CcCallArchiveUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCallArchiveUpdateModel, NesopsService.Data.Entities.CcCallArchive>();
        }

    }
}
