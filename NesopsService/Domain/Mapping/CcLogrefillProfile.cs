using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcLogrefillProfile
        : AutoMapper.Profile
    {
        public CcLogrefillProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcLogrefill, NesopsService.Domain.Models.CcLogrefillReadModel>();
            CreateMap<NesopsService.Domain.Models.CcLogrefillCreateModel, NesopsService.Data.Entities.CcLogrefill>();
            CreateMap<NesopsService.Data.Entities.CcLogrefill, NesopsService.Domain.Models.CcLogrefillUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcLogrefillUpdateModel, NesopsService.Data.Entities.CcLogrefill>();
        }

    }
}
