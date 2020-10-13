using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcLogpaymentRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; }
    }
}
