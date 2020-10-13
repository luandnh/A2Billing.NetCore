using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcPaypalCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string PayerId { get; set; }

        public string PaymentDate { get; set; }

        public string TxnId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PayerEmail { get; set; }

        public string PayerStatus { get; set; }

        public string PaymentType { get; set; }

        public string Memo { get; set; }

        public string ItemName { get; set; }

        public string ItemNumber { get; set; }

        public int Quantity { get; set; }

        public decimal? McGross { get; set; }

        public decimal? McFee { get; set; }

        public decimal? Tax { get; set; }

        public string McCurrency { get; set; }

        public string AddressName { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string AddressZip { get; set; }

        public string AddressCountry { get; set; }

        public string AddressStatus { get; set; }

        public string PayerBusinessName { get; set; }

        public string PaymentStatus { get; set; }

        public string PendingReason { get; set; }

        public string ReasonCode { get; set; }

        public string TxnType { get; set; }

        #endregion

    }
}
