using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcSpeeddialProfile
        : AutoMapper.Profile
    {
        public CcSpeeddialProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcSpeeddial, NesopsService.Domain.Models.CcSpeeddialReadModel>();
            CreateMap<NesopsService.Domain.Models.CcSpeeddialCreateModel, NesopsService.Data.Entities.CcSpeeddial>();
            CreateMap<NesopsService.Data.Entities.CcSpeeddial, NesopsService.Domain.Models.CcSpeeddialUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcSpeeddialUpdateModel, NesopsService.Data.Entities.CcSpeeddial>();
        }

    }
}
