using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcBillingCustomer
    {
        public CcBillingCustomer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public long IdInvoice { get; set; }

        public DateTime? StartDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
