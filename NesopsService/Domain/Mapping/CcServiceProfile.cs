using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcServiceProfile
        : AutoMapper.Profile
    {
        public CcServiceProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcService, NesopsService.Domain.Models.CcServiceReadModel>();
            CreateMap<NesopsService.Domain.Models.CcServiceCreateModel, NesopsService.Data.Entities.CcService>();
            CreateMap<NesopsService.Data.Entities.CcService, NesopsService.Domain.Models.CcServiceUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcServiceUpdateModel, NesopsService.Data.Entities.CcService>();
        }

    }
}
