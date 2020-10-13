using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcDidUseUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long? IdCcCard { get; set; }

        public long IdDid { get; set; }

        public DateTime Reservationdate { get; set; }

        public DateTime Releasedate { get; set; }

        public int? Activated { get; set; }

        public int? MonthPayed { get; set; }

        public sbyte Reminded { get; set; }

        #endregion

    }
}
