using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcAgentSignupUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int IdAgent { get; set; }

        public string Code { get; set; }

        public int IdTariffgroup { get; set; }

        public int IdGroup { get; set; }

        #endregion

    }
}
