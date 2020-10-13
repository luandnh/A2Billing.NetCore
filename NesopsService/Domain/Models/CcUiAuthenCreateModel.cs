using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcUiAuthenCreateModel
    {
        #region Generated Properties
        public long Userid { get; set; }

        public string Login { get; set; }

        public string PwdEncoded { get; set; }

        public int? Groupid { get; set; }

        public int? Perms { get; set; }

        public int? Confaddcust { get; set; }

        public string Name { get; set; }

        public string Direction { get; set; }

        public string Zipcode { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public DateTime Datecreation { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        #endregion

    }
}
