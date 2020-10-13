using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCallArchiveCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Sessionid { get; set; }

        public string Uniqueid { get; set; }

        public long CardId { get; set; }

        public string Nasipaddress { get; set; }

        public DateTime Starttime { get; set; }

        public DateTime Stoptime { get; set; }

        public int? Sessiontime { get; set; }

        public string Calledstation { get; set; }

        public float? Sessionbill { get; set; }

        public int? IdTariffgroup { get; set; }

        public int? IdTariffplan { get; set; }

        public int? IdRatecard { get; set; }

        public int? IdTrunk { get; set; }

        public int? Sipiax { get; set; }

        public string Src { get; set; }

        public int? IdDid { get; set; }

        public decimal? Buycost { get; set; }

        public int? IdCardPackageOffer { get; set; }

        public int? RealSessiontime { get; set; }

        public string Dnid { get; set; }

        public int? Terminatecauseid { get; set; }

        public int? Destination { get; set; }

        #endregion

    }
}
