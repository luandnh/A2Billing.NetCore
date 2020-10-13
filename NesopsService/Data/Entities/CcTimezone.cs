using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcTimezone
    {
        public CcTimezone()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Gmtzone { get; set; }

        public string Gmttime { get; set; }

        public long Gmtoffset { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
