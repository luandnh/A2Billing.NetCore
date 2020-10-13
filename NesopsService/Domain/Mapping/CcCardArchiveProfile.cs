using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardArchiveProfile
        : AutoMapper.Profile
    {
        public CcCardArchiveProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardArchive, NesopsService.Domain.Models.CcCardArchiveReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardArchiveCreateModel, NesopsService.Data.Entities.CcCardArchive>();
            CreateMap<NesopsService.Data.Entities.CcCardArchive, NesopsService.Domain.Models.CcCardArchiveUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardArchiveUpdateModel, NesopsService.Data.Entities.CcCardArchive>();
        }

    }
}
