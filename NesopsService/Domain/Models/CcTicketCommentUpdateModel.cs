using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcTicketCommentUpdateModel
    {
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

    }
}
