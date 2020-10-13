using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcDidUse
    {
        public CcDidUse()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long? IdCcCard { get; set; }

        public long IdDid { get; set; }

        public DateTime Reservationdate { get; set; }

        public DateTime Releasedate { get; set; }

        public int? Activated { get; set; }

        public int? MonthPayed { get; set; }

        public sbyte Reminded { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
