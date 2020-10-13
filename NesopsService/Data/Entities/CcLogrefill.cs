using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcLogrefill : IHaveIdentifier
    {
        public CcLogrefill()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Credit { get; set; }

        public long CardId { get; set; }

        public string Description { get; set; }

        public sbyte RefillType { get; set; }

        public sbyte AddedInvoice { get; set; }

        public long? AgentId { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
