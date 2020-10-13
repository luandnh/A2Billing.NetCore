using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCardPackageOffer
    {
        public CcCardPackageOffer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long IdCcCard { get; set; }

        public long IdCcPackageOffer { get; set; }

        public DateTime DateConsumption { get; set; }

        public long UsedSecondes { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
