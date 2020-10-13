using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcRestrictedPhonenumberProfile
        : AutoMapper.Profile
    {
        public CcRestrictedPhonenumberProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcRestrictedPhonenumber, NesopsService.Domain.Models.CcRestrictedPhonenumberReadModel>();
            CreateMap<NesopsService.Domain.Models.CcRestrictedPhonenumberCreateModel, NesopsService.Data.Entities.CcRestrictedPhonenumber>();
            CreateMap<NesopsService.Data.Entities.CcRestrictedPhonenumber, NesopsService.Domain.Models.CcRestrictedPhonenumberUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcRestrictedPhonenumberUpdateModel, NesopsService.Data.Entities.CcRestrictedPhonenumber>();
        }

    }
}
