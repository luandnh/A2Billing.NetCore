using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcPackageOfferUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime Creationdate { get; set; }

        public string Label { get; set; }

        public int Packagetype { get; set; }

        public int Billingtype { get; set; }

        public int Startday { get; set; }

        public int Freetimetocall { get; set; }

        #endregion

    }
}
