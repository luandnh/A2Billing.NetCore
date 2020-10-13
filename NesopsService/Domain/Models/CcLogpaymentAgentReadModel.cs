using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcLogpaymentAgentReadModel
    {
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

    }
}
