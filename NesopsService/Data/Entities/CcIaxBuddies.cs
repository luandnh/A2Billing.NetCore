using NesopsService.Base.Model;
using System;
using System.Collections.Generic;

namespace NesopsService.Data.Entities
{
    public partial class CcIaxBuddies : IHaveIdentifier
    {
        public CcIaxBuddies()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int IdCcCard { get; set; }

        public string Name { get; set; }

        public string Accountcode { get; set; }

        public string Regexten { get; set; }

        public string Amaflags { get; set; }

        public string Callerid { get; set; }

        public string Context { get; set; }

        public string DEFAULTip { get; set; }

        public string Host { get; set; }

        public string Language { get; set; }

        public string Deny { get; set; }

        public string Permit { get; set; }

        public string Mask { get; set; }

        public string Port { get; set; }

        public string Qualify { get; set; }

        public string Secret { get; set; }

        public string Type { get; set; }

        public string Username { get; set; }

        public string Disallow { get; set; }

        public string Allow { get; set; }

        public int Regseconds { get; set; }

        public string Ipaddr { get; set; }

        public string Trunk { get; set; }

        public string Dbsecret { get; set; }

        public string Regcontext { get; set; }

        public string Sourceaddress { get; set; }

        public string Mohinterpret { get; set; }

        public string Mohsuggest { get; set; }

        public string Inkeys { get; set; }

        public string Outkey { get; set; }

        public string CidNumber { get; set; }

        public string Sendani { get; set; }

        public string Fullname { get; set; }

        public string Auth { get; set; }

        public string Maxauthreq { get; set; }

        public string Encryption { get; set; }

        public string Transfer { get; set; }

        public string Jitterbuffer { get; set; }

        public string Forcejitterbuffer { get; set; }

        public string Codecpriority { get; set; }

        public string Qualifysmoothing { get; set; }

        public string Qualifyfreqok { get; set; }

        public string Qualifyfreqnotok { get; set; }

        public string Timezone { get; set; }

        public string Adsi { get; set; }

        public string Setvar { get; set; }

        public string Requirecalltoken { get; set; }

        public string Maxcallnumbers { get; set; }

        public string MaxcallnumbersNonvalidated { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
