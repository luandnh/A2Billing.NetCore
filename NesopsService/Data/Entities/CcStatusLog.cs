using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcStatusLog
    {
        public CcStatusLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int Status { get; set; }

        public long IdCcCard { get; set; }

        public DateTime UpdatedDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
