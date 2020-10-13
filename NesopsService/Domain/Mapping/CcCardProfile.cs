using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardProfile
        : AutoMapper.Profile
    {
        public CcCardProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCard, NesopsService.Domain.Models.CcCardReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardCreateModel, NesopsService.Data.Entities.CcCard>();
            CreateMap<NesopsService.Data.Entities.CcCard, NesopsService.Domain.Models.CcCardUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardUpdateModel, NesopsService.Data.Entities.CcCard>();
        }

    }
}
