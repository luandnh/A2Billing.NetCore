using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcTicketCommentProfile
        : AutoMapper.Profile
    {
        public CcTicketCommentProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcTicketComment, NesopsService.Domain.Models.CcTicketCommentReadModel>();
            CreateMap<NesopsService.Domain.Models.CcTicketCommentCreateModel, NesopsService.Data.Entities.CcTicketComment>();
            CreateMap<NesopsService.Data.Entities.CcTicketComment, NesopsService.Domain.Models.CcTicketCommentUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcTicketCommentUpdateModel, NesopsService.Data.Entities.CcTicketComment>();
        }

    }
}
