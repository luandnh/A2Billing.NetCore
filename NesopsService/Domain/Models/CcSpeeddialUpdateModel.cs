using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcSpeeddialUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCcCard { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public int? Speeddial { get; set; }

        public DateTime Creationdate { get; set; }

        #endregion

    }
}
