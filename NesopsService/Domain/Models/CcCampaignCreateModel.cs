using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCampaignCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Creationdate { get; set; }

        public DateTime Startingdate { get; set; }

        public DateTime Expirationdate { get; set; }

        public string Description { get; set; }

        public long IdCard { get; set; }

        public int? Secondusedreal { get; set; }

        public int? NbCallmade { get; set; }

        public int Status { get; set; }

        public int Frequency { get; set; }

        public string ForwardNumber { get; set; }

        public TimeSpan DailyStartTime { get; set; }

        public TimeSpan DailyStopTime { get; set; }

        public sbyte Monday { get; set; }

        public sbyte Tuesday { get; set; }

        public sbyte Wednesday { get; set; }

        public sbyte Thursday { get; set; }

        public sbyte Friday { get; set; }

        public sbyte Saturday { get; set; }

        public sbyte Sunday { get; set; }

        public int IdCidGroup { get; set; }

        public int IdCampaignConfig { get; set; }

        #endregion

    }
}
