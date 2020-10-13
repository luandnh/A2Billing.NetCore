using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcRatecardCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int Idtariffplan { get; set; }

        public string Dialprefix { get; set; }

        public decimal Buyrate { get; set; }

        public int Buyrateinitblock { get; set; }

        public int Buyrateincrement { get; set; }

        public decimal Rateinitial { get; set; }

        public int Initblock { get; set; }

        public int Billingblock { get; set; }

        public decimal Connectcharge { get; set; }

        public decimal Disconnectcharge { get; set; }

        public decimal Stepchargea { get; set; }

        public decimal Chargea { get; set; }

        public int Timechargea { get; set; }

        public int Billingblocka { get; set; }

        public decimal Stepchargeb { get; set; }

        public decimal Chargeb { get; set; }

        public int Timechargeb { get; set; }

        public int Billingblockb { get; set; }

        public float Stepchargec { get; set; }

        public float Chargec { get; set; }

        public int Timechargec { get; set; }

        public int Billingblockc { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Stopdate { get; set; }

        public ushort? Starttime { get; set; }

        public ushort? Endtime { get; set; }

        public int? IdTrunk { get; set; }

        public string Musiconhold { get; set; }

        public int? IdOutboundCidgroup { get; set; }

        public int RoundingCalltime { get; set; }

        public int RoundingThreshold { get; set; }

        public decimal AdditionalBlockCharge { get; set; }

        public int AdditionalBlockChargeTime { get; set; }

        public string Tag { get; set; }

        public int DisconnectchargeAfter { get; set; }

        public int? IsMerged { get; set; }

        public int AdditionalGrace { get; set; }

        public decimal MinimalCost { get; set; }

        public decimal AnnounceTimeCorrection { get; set; }

        public long Destination { get; set; }

        #endregion

    }
}
