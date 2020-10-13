using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcContactReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long CardId { get; set; }

        public DateTime Creationdate { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Phonenumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public ulong Active { get; set; }

        #endregion

    }
}
