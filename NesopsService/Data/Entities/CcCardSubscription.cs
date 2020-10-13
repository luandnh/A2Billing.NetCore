using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCardSubscription
    {
        public CcCardSubscription()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long? IdCcCard { get; set; }

        public int? IdSubscriptionFee { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Stopdate { get; set; }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public sbyte PaidStatus { get; set; }

        public DateTime LastRun { get; set; }

        public DateTime NextBillingDate { get; set; }

        public DateTime LimitPayDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
