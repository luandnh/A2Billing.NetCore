using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcDidDestination
    {
        public CcDidDestination()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Destination { get; set; }

        public int Priority { get; set; }

        public long IdCcCard { get; set; }

        public long IdCcDid { get; set; }

        public DateTime Creationdate { get; set; }

        public int Activated { get; set; }

        public int? Secondusedreal { get; set; }

        public int? VoipCall { get; set; }

        public int? Validated { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
