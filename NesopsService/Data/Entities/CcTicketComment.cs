using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcTicketComment : IHaveIdentifier
    {
        public CcTicketComment()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public long IdTicket { get; set; }

        public string Description { get; set; }

        public long Creator { get; set; }

        public sbyte CreatorType { get; set; }

        public sbyte ViewedCust { get; set; }

        public sbyte ViewedAgent { get; set; }

        public sbyte ViewedAdmin { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
