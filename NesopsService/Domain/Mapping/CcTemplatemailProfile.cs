using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTemplatemailProfile
        : AutoMapper.Profile
    {
        public CcTemplatemailProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTemplatemail, NesopsService.Domain.Models.CcTemplatemailReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTemplatemailCreateModel, NesopsService.Data.Entities.CcTemplatemail>();
            CreateMap<NesopsService.Data.Entities.CcTemplatemail, NesopsService.Domain.Models.CcTemplatemailUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTemplatemailUpdateModel, NesopsService.Data.Entities.CcTemplatemail>();
        }

    }
}
