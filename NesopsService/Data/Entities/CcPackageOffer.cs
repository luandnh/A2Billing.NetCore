using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcPackageOffer
    {
        public CcPackageOffer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Creationdate { get; set; }

        public string Label { get; set; }

        public int Packagetype { get; set; }

        public int Billingtype { get; set; }

        public int Startday { get; set; }

        public int Freetimetocall { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
