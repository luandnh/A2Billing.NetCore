using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCalleridProfile
        : AutoMapper.Profile
    {
        public CcCalleridProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCallerid, NesopsService.Domain.Models.CcCalleridReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCalleridCreateModel, NesopsService.Data.Entities.CcCallerid>();
            CreateMap<NesopsService.Data.Entities.CcCallerid, NesopsService.Domain.Models.CcCalleridUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCalleridUpdateModel, NesopsService.Data.Entities.CcCallerid>();
        }

    }
}
