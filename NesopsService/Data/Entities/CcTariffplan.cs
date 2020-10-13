using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcTariffplan : IHaveIdentifier
    {
        public CcTariffplan()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int Iduser { get; set; }

        public string Tariffname { get; set; }

        public DateTime Creationdate { get; set; }

        public DateTime Startingdate { get; set; }

        public DateTime Expirationdate { get; set; }

        public string Description { get; set; }

        public int? IdTrunk { get; set; }

        public int? Secondusedreal { get; set; }

        public int? Secondusedcarrier { get; set; }

        public int? Secondusedratecard { get; set; }

        public int? Reftariffplan { get; set; }

        public int? Idowner { get; set; }

        public string Dnidprefix { get; set; }

        public string Calleridprefix { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
