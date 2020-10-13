using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcVoucher : IHaveIdentifier
    {
        public CcVoucher()
        {
            #region Generated Constructor
            #endregion
        }

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

        #region Generated Relationships
        #endregion

    }
}
