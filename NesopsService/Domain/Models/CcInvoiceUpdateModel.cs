using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcInvoiceUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Reference { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public sbyte PaidStatus { get; set; }

        public sbyte Status { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        #endregion

    }
}
