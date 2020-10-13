using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcContactProfile
        : AutoMapper.Profile
    {
        public CcContactProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcContact, NesopsService.Domain.Models.CcContactReadModel>();
            CreateMap<NesopsService.Domain.Models.CcContactCreateModel, NesopsService.Data.Entities.CcContact>();
            CreateMap<NesopsService.Data.Entities.CcContact, NesopsService.Domain.Models.CcContactUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcContactUpdateModel, NesopsService.Data.Entities.CcContact>();
        }

    }
}
