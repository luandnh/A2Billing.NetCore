using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcServerGroupProfile
        : AutoMapper.Profile
    {
        public CcServerGroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcServerGroup, NesopsService.Domain.Models.CcServerGroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcServerGroupCreateModel, NesopsService.Data.Entities.CcServerGroup>();
            CreateMap<NesopsService.Data.Entities.CcServerGroup, NesopsService.Domain.Models.CcServerGroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcServerGroupUpdateModel, NesopsService.Data.Entities.CcServerGroup>();
        }

    }
}
