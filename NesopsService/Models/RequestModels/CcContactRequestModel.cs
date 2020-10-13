using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcContactRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; } = null;
    }
}
