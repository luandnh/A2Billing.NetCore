using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcLogrefillAgent
    {
        public CcLogrefillAgent()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Credit { get; set; }

        public long AgentId { get; set; }

        public string Description { get; set; }

        public sbyte RefillType { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
