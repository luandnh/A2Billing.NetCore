using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcNotificationReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string KeyValue { get; set; }

        public DateTime Date { get; set; }

        public sbyte Priority { get; set; }

        public sbyte FromType { get; set; }

        public long? FromId { get; set; }

        public long? LinkId { get; set; }

        public string LinkType { get; set; }

        #endregion

    }
}
