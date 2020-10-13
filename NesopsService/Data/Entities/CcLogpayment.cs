using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcLogpayment : IHaveIdentifier
    {
        public CcLogpayment()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Payment { get; set; }

        public long CardId { get; set; }

        public long? IdLogrefill { get; set; }

        public string Description { get; set; }

        public short AddedRefill { get; set; }

        public sbyte PaymentType { get; set; }

        public sbyte AddedCommission { get; set; }

        public long? AgentId { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
