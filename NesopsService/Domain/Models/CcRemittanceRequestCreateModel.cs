using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcRemittanceRequestCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdAgent { get; set; }

        public decimal Amount { get; set; }

        public sbyte Type { get; set; }

        public DateTime Date { get; set; }

        public sbyte Status { get; set; }

        #endregion

    }
}
