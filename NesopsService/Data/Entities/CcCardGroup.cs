using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcCardGroup : IHaveIdentifier
    {
        public CcCardGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UsersPerms { get; set; }

        public int? IdAgent { get; set; }

        public string Provisioning { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
