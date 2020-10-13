using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPaypalProfile
        : AutoMapper.Profile
    {
        public CcPaypalProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPaypal, NesopsService.Domain.Models.CcPaypalReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPaypalCreateModel, NesopsService.Data.Entities.CcPaypal>();
            CreateMap<NesopsService.Data.Entities.CcPaypal, NesopsService.Domain.Models.CcPaypalUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPaypalUpdateModel, NesopsService.Data.Entities.CcPaypal>();
        }

    }
}
