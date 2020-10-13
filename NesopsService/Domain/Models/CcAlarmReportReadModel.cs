using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcAlarmReportReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long CcAlarmId { get; set; }

        public float Calculatedvalue { get; set; }

        public DateTime Daterun { get; set; }

        #endregion

    }
}
