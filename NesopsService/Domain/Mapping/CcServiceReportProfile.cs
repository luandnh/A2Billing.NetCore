using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class CcServiceReportProfile
        : AutoMapper.Profile
    {
        public CcServiceReportProfile()
        {
            CreateMap<NesopsService.Data.Entities.CcServiceReport, NesopsService.Domain.Models.CcServiceReportReadModel>();
            CreateMap<NesopsService.Domain.Models.CcServiceReportCreateModel, NesopsService.Data.Entities.CcServiceReport>();
            CreateMap<NesopsService.Data.Entities.CcServiceReport, NesopsService.Domain.Models.CcServiceReportUpdateModel>();
            CreateMap<NesopsService.Domain.Models.CcServiceReportUpdateModel, NesopsService.Data.Entities.CcServiceReport>();
        }

    }
}
