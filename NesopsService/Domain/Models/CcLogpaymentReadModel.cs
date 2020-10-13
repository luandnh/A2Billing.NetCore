using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcLogpaymentReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

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

    }
}
