using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCurrenciesUpdateModel
    {
        #region Generated Properties
        public ushort Id { get; set; }

        public string Currency { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public DateTime Lastupdate { get; set; }

        public string Basecurrency { get; set; }

        #endregion

    }
}
