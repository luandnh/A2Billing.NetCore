using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcTicketReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public short IdComponent { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public short Priority { get; set; }

        public DateTime Creationdate { get; set; }

        public long Creator { get; set; }

        public short Status { get; set; }

        public sbyte CreatorType { get; set; }

        public sbyte ViewedCust { get; set; }

        public sbyte ViewedAgent { get; set; }

        public sbyte ViewedAdmin { get; set; }

        #endregion

    }
}
