using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcDid
    {
        public CcDid()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long IdCcDidgroup { get; set; }

        public int IdCcCountry { get; set; }

        public int Activated { get; set; }

        public int? Reserved { get; set; }

        public long Iduser { get; set; }

        public string Did { get; set; }

        public DateTime Creationdate { get; set; }

        public DateTime Startingdate { get; set; }

        public DateTime Expirationdate { get; set; }

        public string Description { get; set; }

        public int? Secondusedreal { get; set; }

        public int? Billingtype { get; set; }

        public float Fixrate { get; set; }

        public decimal ConnectionCharge { get; set; }

        public decimal SellingRate { get; set; }

        public decimal AlegCarrierConnectCharge { get; set; }

        public decimal AlegCarrierCostMin { get; set; }

        public decimal AlegRetailConnectCharge { get; set; }

        public decimal AlegRetailCostMin { get; set; }

        public int AlegCarrierInitblock { get; set; }

        public int AlegCarrierIncrement { get; set; }

        public int AlegRetailInitblock { get; set; }

        public int AlegRetailIncrement { get; set; }

        public string AlegTimeinterval { get; set; }

        public decimal AlegCarrierConnectChargeOffp { get; set; }

        public decimal AlegCarrierCostMinOffp { get; set; }

        public decimal AlegRetailConnectChargeOffp { get; set; }

        public decimal AlegRetailCostMinOffp { get; set; }

        public int AlegCarrierInitblockOffp { get; set; }

        public int AlegCarrierIncrementOffp { get; set; }

        public int AlegRetailInitblockOffp { get; set; }

        public int AlegRetailIncrementOffp { get; set; }

        public int MaxConcurrent { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
