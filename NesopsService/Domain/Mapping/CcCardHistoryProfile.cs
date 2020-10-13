using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcCardHistoryProfile
        : AutoMapper.Profile
    {
        public CcCardHistoryProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcCardHistory, NesopsService.Domain.Models.CcCardHistoryReadModel>();
            CreateMap<NesopsService.Domain.Models.CcCardHistoryCreateModel, NesopsService.Data.Entities.CcCardHistory>();
            CreateMap<NesopsService.Data.Entities.CcCardHistory, NesopsService.Domain.Models.CcCardHistoryUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcCardHistoryUpdateModel, NesopsService.Data.Entities.CcCardHistory>();
        }

    }
}
