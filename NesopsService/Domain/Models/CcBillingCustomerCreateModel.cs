using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcBillingCustomerCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public long IdInvoice { get; set; }

        public DateTime? StartDate { get; set; }

        #endregion

    }
}
