using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCardGroupCreateModel
    {
        #region Generated Properties
        public string Name { get; set; }

        public string Description { get; set; } = "";

        public int UsersPerms { get; set; } = 0;

        public int? IdAgent { get; set; } = null;

        public string Provisioning { get; set; } = null;

        #endregion

    }
}
