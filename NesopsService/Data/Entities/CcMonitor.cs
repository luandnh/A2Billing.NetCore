using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcMonitor
    {
        public CcMonitor()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Label { get; set; }

        public int? DialCode { get; set; }

        public string Description { get; set; }

        public string TextIntro { get; set; }

        public sbyte QueryType { get; set; }

        public string Query { get; set; }

        public sbyte ResultType { get; set; }

        public sbyte Enable { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
