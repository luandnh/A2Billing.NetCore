using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCardArchive
    {
        public CcCardArchive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Creationdate { get; set; }

        public DateTime Firstusedate { get; set; }

        public DateTime Expirationdate { get; set; }

        public int? Enableexpire { get; set; }

        public int? Expiredays { get; set; }

        public string Username { get; set; }

        public string Useralias { get; set; }

        public string Uipass { get; set; }

        public decimal Credit { get; set; }

        public int? Tariff { get; set; }

        public int? IdDidgroup { get; set; }

        public string Activated { get; set; }

        public int? Status { get; set; }

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

        public int? Inuse { get; set; }

        public int? Simultaccess { get; set; }

        public string Currency { get; set; }

        public DateTime Lastuse { get; set; }

        public int? Nbused { get; set; }

        public int? Typepaid { get; set; }

        public int? Creditlimit { get; set; }

        public int? Voipcall { get; set; }

        public int? SipBuddy { get; set; }

        public int? IaxBuddy { get; set; }

        public string Language { get; set; }

        public string Redial { get; set; }

        public int? Runservice { get; set; }

        public int? Nbservice { get; set; }

        public int? IdCampaign { get; set; }

        public long? NumTrialsDone { get; set; }

        public float Vat { get; set; }

        public DateTime Servicelastrun { get; set; }

        public decimal Initialbalance { get; set; }

        public int? Invoiceday { get; set; }

        public int? Autorefill { get; set; }

        public string Loginkey { get; set; }

        public string Activatedbyuser { get; set; }

        public int? IdTimezone { get; set; }

        public string Tag { get; set; }

        public int VoicemailPermitted { get; set; }

        public short VoicemailActivated { get; set; }

        public DateTime? LastNotification { get; set; }

        public string EmailNotification { get; set; }

        public short NotifyEmail { get; set; }

        public int CreditNotification { get; set; }

        public int IdGroup { get; set; }

        public string CompanyName { get; set; }

        public string CompanyWebsite { get; set; }

        public string VatRn { get; set; }

        public long? Traffic { get; set; }

        public string TrafficTarget { get; set; }

        public decimal Discount { get; set; }

        public sbyte Restriction { get; set; }

        public string MacAddr { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
