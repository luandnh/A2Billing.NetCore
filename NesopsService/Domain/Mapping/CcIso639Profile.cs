using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcIso639Profile
        : AutoMapper.Profile
    {
        public CcIso639Profile()
        {
            CreateMap<NesopsService.Data.Entities.CcIso639, NesopsService.Domain.Models.CcIso639ReadModel>();
            CreateMap<NesopsService.Domain.Models.CcIso639CreateModel, NesopsService.Data.Entities.CcIso639>();
            CreateMap<NesopsService.Data.Entities.CcIso639, NesopsService.Domain.Models.CcIso639UpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcIso639UpdateModel, NesopsService.Data.Entities.CcIso639>();
        }

    }
}
