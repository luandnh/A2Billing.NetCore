using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcLogpaymentAgent
    {
        public CcLogpaymentAgent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Payment { get; set; }

        public long AgentId { get; set; }

        public long? IdLogrefill { get; set; }

        public string Description { get; set; }

        public sbyte AddedRefill { get; set; }

        public sbyte PaymentType { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
