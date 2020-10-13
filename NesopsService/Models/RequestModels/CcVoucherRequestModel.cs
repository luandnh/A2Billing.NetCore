using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcVoucherRequestModel : BaseRequestModel
    {
        public string usedcardnumber { get; set; }
        public bool? activated { get; set; }
    }
}
