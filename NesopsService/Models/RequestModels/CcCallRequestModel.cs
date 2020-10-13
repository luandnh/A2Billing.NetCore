using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcCallRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; }
        public int? terminateCauseId { get; set; }
        public string phoneNumber { get; set; }
    }
}
