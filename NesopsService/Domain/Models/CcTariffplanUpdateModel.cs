using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcTariffplanUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

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

    }
}
