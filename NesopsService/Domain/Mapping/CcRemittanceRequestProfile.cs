using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcRemittanceRequestProfile
        : AutoMapper.Profile
    {
        public CcRemittanceRequestProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcRemittanceRequest, NesopsService.Domain.Models.CcRemittanceRequestReadModel>();
            CreateMap<NesopsService.Domain.Models.CcRemittanceRequestCreateModel, NesopsService.Data.Entities.CcRemittanceRequest>();
            CreateMap<NesopsService.Data.Entities.CcRemittanceRequest, NesopsService.Domain.Models.CcRemittanceRequestUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcRemittanceRequestUpdateModel, NesopsService.Data.Entities.CcRemittanceRequest>();
        }

    }
}
