using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcMessageAgentReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int IdAgent { get; set; }

        public string Message { get; set; }

        public sbyte Type { get; set; }

        public sbyte Logo { get; set; }

        public int OrderDisplay { get; set; }

        #endregion

    }
}
