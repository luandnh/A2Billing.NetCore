using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcSubscriptionServiceCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Label { get; set; }

        public float Fee { get; set; }

        public int Status { get; set; }

        public int Numberofrun { get; set; }

        public DateTime Datecreate { get; set; }

        public DateTime Datelastrun { get; set; }

        public string Emailreport { get; set; }

        public float Totalcredit { get; set; }

        public int Totalcardperform { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Stopdate { get; set; }

        #endregion

    }
}
