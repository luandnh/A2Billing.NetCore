using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCampaignPhonestatus
    {
        public CcCampaignPhonestatus()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long IdPhonenumber { get; set; }

        public int IdCampaign { get; set; }

        public string IdCallback { get; set; }

        public int Status { get; set; }

        public DateTime Lastuse { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
