using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcContactCreateModel
    {
        #region Generated Properties
        public long CardId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Phonenumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public ulong Active { get; set; } = 1;

        #endregion

    }
}
