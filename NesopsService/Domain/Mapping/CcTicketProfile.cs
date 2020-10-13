using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTicketProfile
        : AutoMapper.Profile
    {
        public CcTicketProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTicket, NesopsService.Domain.Models.CcTicketReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTicketCreateModel, NesopsService.Data.Entities.CcTicket>();
            CreateMap<NesopsService.Data.Entities.CcTicket, NesopsService.Domain.Models.CcTicketUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTicketUpdateModel, NesopsService.Data.Entities.CcTicket>();
        }

    }
}
