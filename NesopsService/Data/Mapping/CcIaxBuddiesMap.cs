using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcIaxBuddiesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcIaxBuddies>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcIaxBuddies> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_iax_buddies");

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

            builder.Property(t => t.Callerid)
                .IsRequired()
                .HasColumnName("callerid")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Context)
                .IsRequired()
                .HasColumnName("context")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.DEFAULTip)
                .HasColumnName("DEFAULTip")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Host)
                .IsRequired()
                .HasColumnName("host")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Language)
                .HasColumnName("language")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

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
                .HasMaxLength(100);

            builder.Property(t => t.Allow)
                .IsRequired()
                .HasColumnName("allow")
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

            builder.Property(t => t.Trunk)
                .HasColumnName("trunk")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'no'");

            builder.Property(t => t.Dbsecret)
                .IsRequired()
                .HasColumnName("dbsecret")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Regcontext)
                .IsRequired()
                .HasColumnName("regcontext")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Sourceaddress)
                .IsRequired()
                .HasColumnName("sourceaddress")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Mohinterpret)
                .IsRequired()
                .HasColumnName("mohinterpret")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Mohsuggest)
                .IsRequired()
                .HasColumnName("mohsuggest")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Inkeys)
                .IsRequired()
                .HasColumnName("inkeys")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Outkey)
                .IsRequired()
                .HasColumnName("outkey")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.CidNumber)
                .IsRequired()
                .HasColumnName("cid_number")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Sendani)
                .IsRequired()
                .HasColumnName("sendani")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Fullname)
                .IsRequired()
                .HasColumnName("fullname")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Auth)
                .IsRequired()
                .HasColumnName("auth")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Maxauthreq)
                .IsRequired()
                .HasColumnName("maxauthreq")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Encryption)
                .IsRequired()
                .HasColumnName("encryption")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Transfer)
                .IsRequired()
                .HasColumnName("transfer")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Jitterbuffer)
                .IsRequired()
                .HasColumnName("jitterbuffer")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Forcejitterbuffer)
                .IsRequired()
                .HasColumnName("forcejitterbuffer")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Codecpriority)
                .IsRequired()
                .HasColumnName("codecpriority")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Qualifysmoothing)
                .IsRequired()
                .HasColumnName("qualifysmoothing")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Qualifyfreqok)
                .IsRequired()
                .HasColumnName("qualifyfreqok")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Qualifyfreqnotok)
                .IsRequired()
                .HasColumnName("qualifyfreqnotok")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Timezone)
                .IsRequired()
                .HasColumnName("timezone")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Adsi)
                .IsRequired()
                .HasColumnName("adsi")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Setvar)
                .IsRequired()
                .HasColumnName("setvar")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Requirecalltoken)
                .IsRequired()
                .HasColumnName("requirecalltoken")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Maxcallnumbers)
                .IsRequired()
                .HasColumnName("maxcallnumbers")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            builder.Property(t => t.MaxcallnumbersNonvalidated)
                .IsRequired()
                .HasColumnName("maxcallnumbers_nonvalidated")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("''");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_iax_buddies";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnName = "name";
        public const string ColumnAccountcode = "accountcode";
        public const string ColumnRegexten = "regexten";
        public const string ColumnAmaflags = "amaflags";
        public const string ColumnCallerid = "callerid";
        public const string ColumnContext = "context";
        public const string ColumnDEFAULTip = "DEFAULTip";
        public const string ColumnHost = "host";
        public const string ColumnLanguage = "language";
        public const string ColumnDeny = "deny";
        public const string ColumnPermit = "permit";
        public const string ColumnMask = "mask";
        public const string ColumnPort = "port";
        public const string ColumnQualify = "qualify";
        public const string ColumnSecret = "secret";
        public const string ColumnType = "type";
        public const string ColumnUsername = "username";
        public const string ColumnDisallow = "disallow";
        public const string ColumnAllow = "allow";
        public const string ColumnRegseconds = "regseconds";
        public const string ColumnIpaddr = "ipaddr";
        public const string ColumnTrunk = "trunk";
        public const string ColumnDbsecret = "dbsecret";
        public const string ColumnRegcontext = "regcontext";
        public const string ColumnSourceaddress = "sourceaddress";
        public const string ColumnMohinterpret = "mohinterpret";
        public const string ColumnMohsuggest = "mohsuggest";
        public const string ColumnInkeys = "inkeys";
        public const string ColumnOutkey = "outkey";
        public const string ColumnCidNumber = "cid_number";
        public const string ColumnSendani = "sendani";
        public const string ColumnFullname = "fullname";
        public const string ColumnAuth = "auth";
        public const string ColumnMaxauthreq = "maxauthreq";
        public const string ColumnEncryption = "encryption";
        public const string ColumnTransfer = "transfer";
        public const string ColumnJitterbuffer = "jitterbuffer";
        public const string ColumnForcejitterbuffer = "forcejitterbuffer";
        public const string ColumnCodecpriority = "codecpriority";
        public const string ColumnQualifysmoothing = "qualifysmoothing";
        public const string ColumnQualifyfreqok = "qualifyfreqok";
        public const string ColumnQualifyfreqnotok = "qualifyfreqnotok";
        public const string ColumnTimezone = "timezone";
        public const string ColumnAdsi = "adsi";
        public const string ColumnSetvar = "setvar";
        public const string ColumnRequirecalltoken = "requirecalltoken";
        public const string ColumnMaxcallnumbers = "maxcallnumbers";
        public const string ColumnMaxcallnumbersNonvalidated = "maxcallnumbers_nonvalidated";
        #endregion
    }
}
