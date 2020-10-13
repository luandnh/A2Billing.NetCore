using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcServiceCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Name { get; set; }

        public float Amount { get; set; }

        public int Period { get; set; }

        public int Rule { get; set; }

        public int Daynumber { get; set; }

        public int Stopmode { get; set; }

        public int Maxnumbercycle { get; set; }

        public int Status { get; set; }

        public int Numberofrun { get; set; }

        public DateTime Datecreate { get; set; }

        public DateTime Datelastrun { get; set; }

        public string Emailreport { get; set; }

        public float Totalcredit { get; set; }

        public int Totalcardperform { get; set; }

        public sbyte? OperateMode { get; set; }

        public int? Dialplan { get; set; }

        public sbyte? UseGroup { get; set; }

        #endregion

    }
}
