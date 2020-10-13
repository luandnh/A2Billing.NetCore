using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NesopsRTC2.Models
{
    public class VoucherModel
    {
        [JsonProperty("cardId")]
        public int cardId { get; set; }
        [JsonProperty("voucherCode")]
        public string voucherCode { get; set; }
    }
}
