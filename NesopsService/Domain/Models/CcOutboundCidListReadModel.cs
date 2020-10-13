using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcOutboundCidListReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int OutboundCidGroup { get; set; }

        public string Cid { get; set; }

        public int Activated { get; set; }

        public DateTime Creationdate { get; set; }

        #endregion

    }
}
