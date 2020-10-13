using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcVoucherUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime Creationdate { get; set; }

        public DateTime Usedate { get; set; }

        public DateTime Expirationdate { get; set; }

        public string Voucher { get; set; }

        public string Usedcardnumber { get; set; }

        public string Tag { get; set; }

        public float Credit { get; set; }

        public string Activated { get; set; }

        public int? Used { get; set; }

        public string Currency { get; set; }

        #endregion

    }
}
