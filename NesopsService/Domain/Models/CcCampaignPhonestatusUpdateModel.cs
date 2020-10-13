using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCampaignPhonestatusUpdateModel
    {
        #region Generated Properties
        public long IdPhonenumber { get; set; }

        public int IdCampaign { get; set; }

        public string IdCallback { get; set; }

        public int Status { get; set; }

        public DateTime Lastuse { get; set; }

        #endregion

    }
}
