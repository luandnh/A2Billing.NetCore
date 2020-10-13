using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcEpaymentLogAgent
    {
        public CcEpaymentLogAgent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long AgentId { get; set; }

        public string Amount { get; set; }

        public float Vat { get; set; }

        public string Paymentmethod { get; set; }

        public string CcOwner { get; set; }

        public string CcNumber { get; set; }

        public string CcExpires { get; set; }

        public DateTime Creationdate { get; set; }

        public int Status { get; set; }

        public string Cvv { get; set; }

        public string CreditCardType { get; set; }

        public string Currency { get; set; }

        public string TransactionDetail { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
