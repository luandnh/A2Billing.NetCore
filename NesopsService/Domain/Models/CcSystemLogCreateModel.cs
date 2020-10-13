using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcSystemLogCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int Iduser { get; set; }

        public int Loglevel { get; set; }

        public string Action { get; set; }

        public string Description { get; set; }

        public Byte[] Data { get; set; }

        public string Tablename { get; set; }

        public string Pagename { get; set; }

        public string Ipaddress { get; set; }

        public DateTime Creationdate { get; set; }

        public sbyte? Agent { get; set; }

        #endregion

    }
}
