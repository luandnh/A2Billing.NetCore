using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSipBuddiesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSipBuddies>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSipBuddies> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_sip_buddies");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("int(11)");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Accountcode)
                .IsRequired()
                .HasColumnName("accountcode")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Regexten)
                .IsRequired()
                .HasColumnName("regexten")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Amaflags)
                .HasColumnName("amaflags")
                .HasColumnType("char(7)")
                .HasMaxLength(7);

            builder.Property(t => t.Callgroup)
                .HasColumnName("callgroup")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Callerid)
                .IsRequired()
                .HasColumnName("callerid")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Canreinvite)
                .IsRequired()
                .HasColumnName("canreinvite")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("'YES'");

            builder.Property(t => t.Context)
                .IsRequired()
                .HasColumnName("context")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.DEFAULTip)
                .HasColumnName("DEFAULTip")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Dtmfmode)
                .IsRequired()
                .HasColumnName("dtmfmode")
                .HasColumnType("char(7)")
                .HasMaxLength(7)
                .HasDefaultValueSql("'RFC2833'");

            builder.Property(t => t.Fromuser)
                .IsRequired()
                .HasColumnName("fromuser")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Fromdomain)
                .IsRequired()
                .HasColumnName("fromdomain")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Host)
                .IsRequired()
                .HasColumnName("host")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Insecure)
                .IsRequired()
                .HasColumnName("insecure")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Language)
                .HasColumnName("language")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(t => t.Mailbox)
                .IsRequired()
                .HasColumnName("mailbox")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Md5secret)
                .IsRequired()
                .HasColumnName("md5secret")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Nat)
                .HasColumnName("nat")
                .HasColumnType("char(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("'yes'");

            builder.Property(t => t.Deny)
                .IsRequired()
                .HasColumnName("deny")
                .HasColumnType("varchar(95)")
                .HasMaxLength(95);

            builder.Property(t => t.Permit)
                .HasColumnName("permit")
                .HasColumnType("varchar(95)")
                .HasMaxLength(95);

            builder.Property(t => t.Mask)
                .IsRequired()
                .HasColumnName("mask")
                .HasColumnType("varchar(95)")
                .HasMaxLength(95);

            builder.Property(t => t.Pickupgroup)
                .HasColumnName("pickupgroup")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Port)
                .IsRequired()
                .HasColumnName("port")
                .HasColumnType("char(5)")
                .HasMaxLength(5)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Qualify)
                .HasColumnName("qualify")
                .HasColumnType("char(7)")
                .HasMaxLength(7)
                .HasDefaultValueSql("'yes'");

            builder.Property(t => t.Restrictcid)
                .HasColumnName("restrictcid")
                .HasColumnType("char(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Rtptimeout)
                .HasColumnName("rtptimeout")
                .HasColumnType("char(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Rtpholdtimeout)
                .HasColumnName("rtpholdtimeout")
                .HasColumnType("char(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Secret)
                .IsRequired()
                .HasColumnName("secret")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("char(6)")
                .HasMaxLength(6)
                .HasDefaultValueSql("'friend'");

            builder.Property(t => t.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Disallow)
                .IsRequired()
                .HasColumnName("disallow")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasDefaultValueSql("'ALL'");

            builder.Property(t => t.Allow)
                .IsRequired()
                .HasColumnName("allow")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Musiconhold)
                .IsRequired()
                .HasColumnName("musiconhold")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Regseconds)
                .IsRequired()
                .HasColumnName("regseconds")
                .HasColumnType("int(11)");

            builder.Property(t => t.Ipaddr)
                .IsRequired()
                .HasColumnName("ipaddr")
                .HasColumnType("char(50)")
                .HasMaxLength(50)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Cancallforward)
                .HasColumnName("cancallforward")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'yes'");

            builder.Property(t => t.Fullcontact)
                .IsRequired()
                .HasColumnName("fullcontact")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Setvar)
                .IsRequired()
                .HasColumnName("setvar")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Regserver)
                .HasColumnName("regserver")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Lastms)
                .HasColumnName("lastms")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11);

            builder.Property(t => t.Defaultuser)
                .IsRequired()
                .HasColumnName("defaultuser")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Auth)
                .IsRequired()
                .HasColumnName("auth")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Subscribemwi)
                .IsRequired()
                .HasColumnName("subscribemwi")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Vmexten)
                .IsRequired()
                .HasColumnName("vmexten")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.CidNumber)
                .IsRequired()
                .HasColumnName("cid_number")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Callingpres)
                .IsRequired()
                .HasColumnName("callingpres")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Usereqphone)
                .IsRequired()
                .HasColumnName("usereqphone")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Incominglimit)
                .IsRequired()
                .HasColumnName("incominglimit")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Subscribecontext)
                .IsRequired()
                .HasColumnName("subscribecontext")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Musicclass)
                .IsRequired()
                .HasColumnName("musicclass")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Mohsuggest)
                .IsRequired()
                .HasColumnName("mohsuggest")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Allowtransfer)
                .IsRequired()
                .HasColumnName("allowtransfer")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Autoframing)
                .IsRequired()
                .HasColumnName("autoframing")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Maxcallbitrate)
                .IsRequired()
                .HasColumnName("maxcallbitrate")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Outboundproxy)
                .IsRequired()
                .HasColumnName("outboundproxy")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Rtpkeepalive)
                .IsRequired()
                .HasColumnName("rtpkeepalive")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Useragent)
                .HasColumnName("useragent")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Callbackextension)
                .HasColumnName("callbackextension")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_sip_buddies";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnName = "name";
        public const string ColumnAccountcode = "accountcode";
        public const string ColumnRegexten = "regexten";
        public const string ColumnAmaflags = "amaflags";
        public const string ColumnCallgroup = "callgroup";
        public const string ColumnCallerid = "callerid";
        public const string ColumnCanreinvite = "canreinvite";
        public const string ColumnContext = "context";
        public const string ColumnDEFAULTip = "DEFAULTip";
        public const string ColumnDtmfmode = "dtmfmode";
        public const string ColumnFromuser = "fromuser";
        public const string ColumnFromdomain = "fromdomain";
        public const string ColumnHost = "host";
        public const string ColumnInsecure = "insecure";
        public const string ColumnLanguage = "language";
        public const string ColumnMailbox = "mailbox";
        public const string ColumnMd5secret = "md5secret";
        public const string ColumnNat = "nat";
        public const string ColumnDeny = "deny";
        public const string ColumnPermit = "permit";
        public const string ColumnMask = "mask";
        public const string ColumnPickupgroup = "pickupgroup";
        public const string ColumnPort = "port";
        public const string ColumnQualify = "qualify";
        public const string ColumnRestrictcid = "restrictcid";
        public const string ColumnRtptimeout = "rtptimeout";
        public const string ColumnRtpholdtimeout = "rtpholdtimeout";
        public const string ColumnSecret = "secret";
        public const string ColumnType = "type";
        public const string ColumnUsername = "username";
        public const string ColumnDisallow = "disallow";
        public const string ColumnAllow = "allow";
        public const string ColumnMusiconhold = "musiconhold";
        public const string ColumnRegseconds = "regseconds";
        public const string ColumnIpaddr = "ipaddr";
        public const string ColumnCancallforward = "cancallforward";
        public const string ColumnFullcontact = "fullcontact";
        public const string ColumnSetvar = "setvar";
        public const string ColumnRegserver = "regserver";
        public const string ColumnLastms = "lastms";
        public const string ColumnDefaultuser = "defaultuser";
        public const string ColumnAuth = "auth";
        public const string ColumnSubscribemwi = "subscribemwi";
        public const string ColumnVmexten = "vmexten";
        public const string ColumnCidNumber = "cid_number";
        public const string ColumnCallingpres = "callingpres";
        public const string ColumnUsereqphone = "usereqphone";
        public const string ColumnIncominglimit = "incominglimit";
        public const string ColumnSubscribecontext = "subscribecontext";
        public const string ColumnMusicclass = "musicclass";
        public const string ColumnMohsuggest = "mohsuggest";
        public const string ColumnAllowtransfer = "allowtransfer";
        public const string ColumnAutoframing = "autoframing";
        public const string ColumnMaxcallbitrate = "maxcallbitrate";
        public const string ColumnOutboundproxy = "outboundproxy";
        public const string ColumnRtpkeepalive = "rtpkeepalive";
        public const string ColumnUseragent = "useragent";
        public const string ColumnCallbackextension = "callbackextension";
        #endregion
    }
}
