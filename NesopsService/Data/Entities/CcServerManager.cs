using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcServerManager
    {
        public CcServerManager()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int? IdGroup { get; set; }

        public string ServerIp { get; set; }

        public string ManagerHost { get; set; }

        public string ManagerUsername { get; set; }

        public string ManagerSecret { get; set; }

        public DateTime LasttimeUsed { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
