using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcTicketRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; }
        public bool? viewedAdmin { get; set; }
        public bool? viewedCust { get; set; }
        public bool? creatorType { get; set; }
        public int? status { get; set; }
    }
}
