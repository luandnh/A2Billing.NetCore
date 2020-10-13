using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcServerManagerProfile
        : AutoMapper.Profile
    {
        public CcServerManagerProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcServerManager, NesopsService.Domain.Models.CcServerManagerReadModel>();
            CreateMap<NesopsService.Domain.Models.CcServerManagerCreateModel, NesopsService.Data.Entities.CcServerManager>();
            CreateMap<NesopsService.Data.Entities.CcServerManager, NesopsService.Domain.Models.CcServerManagerUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcServerManagerUpdateModel, NesopsService.Data.Entities.CcServerManager>();
        }

    }
}
