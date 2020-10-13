using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCallerid : IHaveIdentifier
    {
        public CcCallerid()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Cid { get; set; }

        public long IdCcCard { get; set; }

        public string Activated { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
