using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcUiAuthenProfile
        : AutoMapper.Profile
    {
        public CcUiAuthenProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcUiAuthen, NesopsService.Domain.Models.CcUiAuthenReadModel>();
            CreateMap<NesopsService.Domain.Models.CcUiAuthenCreateModel, NesopsService.Data.Entities.CcUiAuthen>();
            CreateMap<NesopsService.Data.Entities.CcUiAuthen, NesopsService.Domain.Models.CcUiAuthenUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcUiAuthenUpdateModel, NesopsService.Data.Entities.CcUiAuthen>();
        }

    }
}
