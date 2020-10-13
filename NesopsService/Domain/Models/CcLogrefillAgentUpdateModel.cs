using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcLogrefillAgentUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Credit { get; set; }

        public long AgentId { get; set; }

        public string Description { get; set; }

        public sbyte RefillType { get; set; }

        #endregion

    }
}
