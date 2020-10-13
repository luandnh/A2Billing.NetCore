using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardSeriaProfile
        : AutoMapper.Profile
    {
        public CcCardSeriaProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardSeria, NesopsService.Domain.Models.CcCardSeriaReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardSeriaCreateModel, NesopsService.Data.Entities.CcCardSeria>();
            CreateMap<NesopsService.Data.Entities.CcCardSeria, NesopsService.Domain.Models.CcCardSeriaUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardSeriaUpdateModel, NesopsService.Data.Entities.CcCardSeria>();
        }

    }
}
