using System;
using System.Collections.Generic;

namespace NesopsService.Domain.Models
{
    public partial class CcCallbackSpoolReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Uniqueid { get; set; }

        public DateTime EntryTime { get; set; }

        public string Status { get; set; }

        public string ServerIp { get; set; }

        public int NumAttempt { get; set; }

        public DateTime LastAttemptTime { get; set; }

        public string ManagerResult { get; set; }

        public string AgiResult { get; set; }

        public DateTime CallbackTime { get; set; }

        public string Channel { get; set; }

        public string Exten { get; set; }

        public string Context { get; set; }

        public string Priority { get; set; }

        public string Application { get; set; }

        public string Data { get; set; }

        public string Timeout { get; set; }

        public string Callerid { get; set; }

        public string Variable { get; set; }

        public string Account { get; set; }

        public string Async { get; set; }

        public string Actionid { get; set; }

        public int? IdServer { get; set; }

        public int? IdServerGroup { get; set; }

        #endregion

    }
}
