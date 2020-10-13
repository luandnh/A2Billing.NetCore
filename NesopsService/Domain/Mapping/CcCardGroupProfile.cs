using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardGroupProfile
        : AutoMapper.Profile
    {
        public CcCardGroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardGroup, NesopsService.Domain.Models.CcCardGroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardGroupCreateModel, NesopsService.Data.Entities.CcCardGroup>();
            CreateMap<NesopsService.Data.Entities.CcCardGroup, NesopsService.Domain.Models.CcCardGroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardGroupUpdateModel, NesopsService.Data.Entities.CcCardGroup>()
                .ForMember(d => d.Id, o => o.MapFrom((src, dest) => dest.Id))
                .ForMember(d => d.Name, o => o.MapFrom((src, dest) => src.Name == null ? dest.Name : src.Name))
                .ForMember(d => d.Description, o => o.MapFrom((src, dest) => src.Description == null ? dest.Description : src.Description))
                .ForMember(d => d.UsersPerms, o => o.MapFrom((src, dest) => src.UsersPerms == 0 ? dest.UsersPerms : src.UsersPerms))
                .ForMember(d => d.IdAgent, o => o.MapFrom((src, dest) => src.IdAgent == null ? dest.IdAgent : src.IdAgent))
                .ForMember(d => d.Provisioning, o => o.MapFrom((src, dest) => src.Provisioning == null ? dest.Provisioning : src.Provisioning));

        }

    }
}
