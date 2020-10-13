using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcLogrefillRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; } = null;
    }
}
