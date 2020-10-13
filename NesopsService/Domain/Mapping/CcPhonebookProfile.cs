using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcPhonebookProfile
        : AutoMapper.Profile
    {
        public CcPhonebookProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcPhonebook, NesopsService.Domain.Models.CcPhonebookReadModel>();
            CreateMap<NesopsService.Domain.Models.CcPhonebookCreateModel, NesopsService.Data.Entities.CcPhonebook>();
            CreateMap<NesopsService.Data.Entities.CcPhonebook, NesopsService.Domain.Models.CcPhonebookUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcPhonebookUpdateModel, NesopsService.Data.Entities.CcPhonebook>();
        }

    }
}
