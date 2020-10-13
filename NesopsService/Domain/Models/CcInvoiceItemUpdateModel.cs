using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcInvoiceItemUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdInvoice { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public decimal Vat { get; set; }

        public string Description { get; set; }

        public long? IdExt { get; set; }

        public string TypeExt { get; set; }

        #endregion

    }
}
