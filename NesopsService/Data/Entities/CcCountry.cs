using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCountry : IHaveIdentifier
    {
        public CcCountry()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Countrycode { get; set; }

        public string Countryprefix { get; set; }

        public string Countryname { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
