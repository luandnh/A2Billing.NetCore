using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCallplanLcrUpdateModel
    {
        #region Generated Properties
        public int? Id { get; set; }

        public string Destination { get; set; }

        public string Dialprefix { get; set; }

        public decimal? Buyrate { get; set; }

        public decimal? Rateinitial { get; set; }

        public DateTime? Startdate { get; set; }

        public DateTime? Stopdate { get; set; }

        public int? Initblock { get; set; }

        public decimal? Connectcharge { get; set; }

        public int? IdTrunk { get; set; }

        public int? Idtariffplan { get; set; }

        public int? RatecardId { get; set; }

        public int? TariffgroupId { get; set; }

        #endregion

    }
}
