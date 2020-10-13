using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcAlarmReport
    {
        public CcAlarmReport()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long CcAlarmId { get; set; }

        public float Calculatedvalue { get; set; }

        public DateTime Daterun { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
