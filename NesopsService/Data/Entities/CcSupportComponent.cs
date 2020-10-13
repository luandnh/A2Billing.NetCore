using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcSupportComponent : IHaveIdentifier
    {
        public CcSupportComponent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public short IdSupport { get; set; }

        public string Name { get; set; }

        public short Activated { get; set; }

        public sbyte TypeUser { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
