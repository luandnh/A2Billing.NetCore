using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcAgentCommissionUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? IdPayment { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public int IdAgent { get; set; }

        public sbyte CommissionType { get; set; }

        public decimal CommissionPercent { get; set; }

        #endregion

    }
}
