using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcAutorefillReportProfile
        : AutoMapper.Profile
    {
        public CcAutorefillReportProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcAutorefillReport, NesopsService.Domain.Models.CcAutorefillReportReadModel>();
            CreateMap<NesopsService.Domain.Models.CcAutorefillReportCreateModel, NesopsService.Data.Entities.CcAutorefillReport>();
            CreateMap<NesopsService.Data.Entities.CcAutorefillReport, NesopsService.Domain.Models.CcAutorefillReportUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcAutorefillReportUpdateModel, NesopsService.Data.Entities.CcAutorefillReport>();
        }

    }
}
