using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcTemplatemailReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string IdLanguage { get; set; }

        public string Mailtype { get; set; }

        public string Fromemail { get; set; }

        public string Fromname { get; set; }

        public string Subject { get; set; }

        public string Messagetext { get; set; }

        public string Messagehtml { get; set; }

        #endregion

    }
}
