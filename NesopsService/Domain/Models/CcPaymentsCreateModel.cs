using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcPaymentsCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long CustomersId { get; set; }

        public string CustomersName { get; set; }

        public string CustomersEmailAddress { get; set; }

        public string ItemName { get; set; }

        public string ItemId { get; set; }

        public int ItemQuantity { get; set; }

        public string PaymentMethod { get; set; }

        public string CcType { get; set; }

        public string CcOwner { get; set; }

        public string CcNumber { get; set; }

        public string CcExpires { get; set; }

        public int OrdersStatus { get; set; }

        public decimal? OrdersAmount { get; set; }

        public DateTime? LastModified { get; set; }

        public DateTime? DatePurchased { get; set; }

        public DateTime? OrdersDateFinished { get; set; }

        public string Currency { get; set; }

        public decimal? CurrencyValue { get; set; }

        #endregion

    }
}
