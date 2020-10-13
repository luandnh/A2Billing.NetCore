using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcAlarm
    {
        public CcAlarm()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Name { get; set; }

        public int Periode { get; set; }

        public int Type { get; set; }

        public float Maxvalue { get; set; }

        public float Minvalue { get; set; }

        public int? IdTrunk { get; set; }

        public int Status { get; set; }

        public int Numberofrun { get; set; }

        public int Numberofalarm { get; set; }

        public DateTime Datecreate { get; set; }

        public DateTime Datelastrun { get; set; }

        public string Emailreport { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
