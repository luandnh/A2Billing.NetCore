using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPhonenumberProfile
        : AutoMapper.Profile
    {
        public CcPhonenumberProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPhonenumber, NesopsService.Domain.Models.CcPhonenumberReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPhonenumberCreateModel, NesopsService.Data.Entities.CcPhonenumber>();
            CreateMap<NesopsService.Data.Entities.CcPhonenumber, NesopsService.Domain.Models.CcPhonenumberUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPhonenumberUpdateModel, NesopsService.Data.Entities.CcPhonenumber>();
        }

    }
}
