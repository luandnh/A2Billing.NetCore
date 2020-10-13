using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcServiceReport
    {
        public CcServiceReport()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long CcServiceId { get; set; }

        public DateTime Daterun { get; set; }

        public int? Totalcardperform { get; set; }

        public float? Totalcredit { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
