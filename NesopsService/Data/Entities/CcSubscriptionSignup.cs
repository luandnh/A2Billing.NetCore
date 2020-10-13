using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcSubscriptionSignup
    {
        public CcSubscriptionSignup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public string Label { get; set; }

        public long? IdSubscription { get; set; }

        public string Description { get; set; }

        public sbyte Enable { get; set; }

        public long? IdCallplan { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
