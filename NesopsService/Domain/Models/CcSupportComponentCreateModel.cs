using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcSupportComponentCreateModel
    {
        #region Generated Properties
        public short Id { get; set; }

        public short IdSupport { get; set; }

        public string Name { get; set; }

        public short Activated { get; set; }

        public sbyte TypeUser { get; set; }

        #endregion

    }
}
