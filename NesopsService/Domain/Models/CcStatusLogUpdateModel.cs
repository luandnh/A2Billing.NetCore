using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcStatusLogUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int Status { get; set; }

        public long IdCcCard { get; set; }

        public DateTime UpdatedDate { get; set; }

        #endregion

    }
}
