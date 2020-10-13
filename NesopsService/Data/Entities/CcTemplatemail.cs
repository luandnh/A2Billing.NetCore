using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcTemplatemail
    {
        public CcTemplatemail()
        {
            #region Generated Constructor
            #endregion
        }

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

        #region Generated Relationships
        #endregion

    }
}
