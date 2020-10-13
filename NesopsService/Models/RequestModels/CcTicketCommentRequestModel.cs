using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsService.Models.RequestModels
{
    public class CcTicketCommentRequestModel : BaseRequestModel
    {
        public int? cardId { get; set; }
        public int? ticketId { get; set; }
        public bool? viewedAdmin { get; set; }
        public bool? viewedCust { get; set; }
    }
}
