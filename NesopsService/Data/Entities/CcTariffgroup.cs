using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcTariffgroup : IHaveIdentifier
    {
        public CcTariffgroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int Iduser { get; set; }

        public int Idtariffplan { get; set; }

        public string Tariffgroupname { get; set; }

        public int Lcrtype { get; set; }

        public DateTime Creationdate { get; set; }

        public int Removeinterprefix { get; set; }

        public long IdCcPackageOffer { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
