using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCardGroupUpdateModel
    {
        #region Generated Properties
        public string Name { get; set; }

        public string Description { get; set; }

        public int UsersPerms { get; set; }

        public int? IdAgent { get; set; }

        public string Provisioning { get; set; }

        #endregion

    }
}
