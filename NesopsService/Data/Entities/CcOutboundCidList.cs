using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcOutboundCidList
    {
        public CcOutboundCidList()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int OutboundCidGroup { get; set; }

        public string Cid { get; set; }

        public int Activated { get; set; }

        public DateTime Creationdate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
