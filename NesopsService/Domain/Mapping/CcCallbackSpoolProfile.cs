using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCallbackSpoolProfile
        : AutoMapper.Profile
    {
        public CcCallbackSpoolProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCallbackSpool, NesopsService.Domain.Models.CcCallbackSpoolReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCallbackSpoolCreateModel, NesopsService.Data.Entities.CcCallbackSpool>();
            CreateMap<NesopsService.Data.Entities.CcCallbackSpool, NesopsService.Domain.Models.CcCallbackSpoolUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCallbackSpoolUpdateModel, NesopsService.Data.Entities.CcCallbackSpool>();
        }

    }
}
