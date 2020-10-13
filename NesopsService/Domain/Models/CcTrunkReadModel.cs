using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcTrunkReadModel
    {
        #region Generated Properties
        public int IdTrunk { get; set; }

        public string Trunkcode { get; set; }

        public string Trunkprefix { get; set; }

        public string Providertech { get; set; }

        public string Providerip { get; set; }

        public string Removeprefix { get; set; }

        public int? Secondusedreal { get; set; }

        public int? Secondusedcarrier { get; set; }

        public int? Secondusedratecard { get; set; }

        public DateTime Creationdate { get; set; }

        public int? FailoverTrunk { get; set; }

        public string Addparameter { get; set; }

        public int? IdProvider { get; set; }

        public int? Inuse { get; set; }

        public int? Maxuse { get; set; }

        public int? Status { get; set; }

        public int? IfMaxUse { get; set; }

        #endregion

    }
}
