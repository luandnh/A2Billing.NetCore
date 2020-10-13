using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcOutboundCidListProfile
        : AutoMapper.Profile
    {
        public CcOutboundCidListProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcOutboundCidList, NesopsService.Domain.Models.CcOutboundCidListReadModel>();
            CreateMap<NesopsService.Domain.Models.CcOutboundCidListCreateModel, NesopsService.Data.Entities.CcOutboundCidList>();
            CreateMap<NesopsService.Data.Entities.CcOutboundCidList, NesopsService.Domain.Models.CcOutboundCidListUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcOutboundCidListUpdateModel, NesopsService.Data.Entities.CcOutboundCidList>();
        }

    }
}
