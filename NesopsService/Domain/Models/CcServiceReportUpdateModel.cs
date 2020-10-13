using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcServiceReportUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long CcServiceId { get; set; }

        public DateTime Daterun { get; set; }

        public int? Totalcardperform { get; set; }

        public float? Totalcredit { get; set; }

        #endregion

    }
}
