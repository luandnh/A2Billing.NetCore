using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcAutorefillReport
    {
        public CcAutorefillReport()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Daterun { get; set; }

        public int? Totalcardperform { get; set; }

        public decimal? Totalcredit { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
