using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcOutboundCidGroupProfile
        : AutoMapper.Profile
    {
        public CcOutboundCidGroupProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcOutboundCidGroup, NesopsService.Domain.Models.CcOutboundCidGroupReadModel>();
            CreateMap<NesopsService.Domain.Models.CcOutboundCidGroupCreateModel, NesopsService.Data.Entities.CcOutboundCidGroup>();
            CreateMap<NesopsService.Data.Entities.CcOutboundCidGroup, NesopsService.Domain.Models.CcOutboundCidGroupUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcOutboundCidGroupUpdateModel, NesopsService.Data.Entities.CcOutboundCidGroup>();
        }

    }
}
