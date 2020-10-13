using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcBackupProfile
        : AutoMapper.Profile
    {
        public CcBackupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcBackup, NesopsService.Domain.Models.CcBackupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcBackupCreateModel, NesopsService.Data.Entities.CcBackup>();
            CreateMap<NesopsService.Data.Entities.CcBackup, NesopsService.Domain.Models.CcBackupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcBackupUpdateModel, NesopsService.Data.Entities.CcBackup>();
        }

    }
}
