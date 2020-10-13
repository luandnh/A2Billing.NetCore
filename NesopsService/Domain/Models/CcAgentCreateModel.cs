using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcAgentCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime Datecreation { get; set; }

        public string Active { get; set; }

        public string Login { get; set; }

        public string Passwd { get; set; }

        public string Location { get; set; }

        public string Language { get; set; }

        public int? IdTariffgroup { get; set; }

        public int Options { get; set; }

        public decimal Credit { get; set; }

        public string Currency { get; set; }

        public string Locale { get; set; }

        public decimal Commission { get; set; }

        public decimal Vat { get; set; }

        public string Banner { get; set; }

        public int? Perms { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Zipcode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        public string Company { get; set; }

        public decimal ComBalance { get; set; }

        public decimal ThresholdRemittance { get; set; }

        public string BankInfo { get; set; }

        #endregion

    }
}
