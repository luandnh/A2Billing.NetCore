using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCallbackSpoolMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCallbackSpool>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCallbackSpool> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_callback_spool");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Uniqueid)
                .HasColumnName("uniqueid")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.EntryTime)
                .IsRequired()
                .HasColumnName("entry_time")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Status)
                .HasColumnName("status")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80);

            builder.Property(t => t.ServerIp)
                .HasColumnName("server_ip")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.NumAttempt)
                .IsRequired()
                .HasColumnName("num_attempt")
                .HasColumnType("int(11)");

            builder.Property(t => t.LastAttemptTime)
                .IsRequired()
                .HasColumnName("last_attempt_time")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.ManagerResult)
                .HasColumnName("manager_result")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.AgiResult)
                .HasColumnName("agi_result")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.CallbackTime)
                .IsRequired()
                .HasColumnName("callback_time")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Channel)
                .HasColumnName("channel")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Exten)
                .HasColumnName("exten")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Context)
                .HasColumnName("context")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Priority)
                .HasColumnName("priority")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Application)
                .HasColumnName("application")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Data)
                .HasColumnName("data")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Timeout)
                .HasColumnName("timeout")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Callerid)
                .HasColumnName("callerid")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Variable)
                .HasColumnName("variable")
                .HasColumnType("varchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.Account)
                .HasColumnName("account")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Async)
                .HasColumnName("async")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Actionid)
                .HasColumnName("actionid")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.IdServer)
                .HasColumnName("id_server")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdServerGroup)
                .HasColumnName("id_server_group")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_callback_spool";

        public const string ColumnId = "id";
        public const string ColumnUniqueid = "uniqueid";
        public const string ColumnEntryTime = "entry_time";
        public const string ColumnStatus = "status";
        public const string ColumnServerIp = "server_ip";
        public const string ColumnNumAttempt = "num_attempt";
        public const string ColumnLastAttemptTime = "last_attempt_time";
        public const string ColumnManagerResult = "manager_result";
        public const string ColumnAgiResult = "agi_result";
        public const string ColumnCallbackTime = "callback_time";
        public const string ColumnChannel = "channel";
        public const string ColumnExten = "exten";
        public const string ColumnContext = "context";
        public const string ColumnPriority = "priority";
        public const string ColumnApplication = "application";
        public const string ColumnData = "data";
        public const string ColumnTimeout = "timeout";
        public const string ColumnCallerid = "callerid";
        public const string ColumnVariable = "variable";
        public const string ColumnAccount = "account";
        public const string ColumnAsync = "async";
        public const string ColumnActionid = "actionid";
        public const string ColumnIdServer = "id_server";
        public const string ColumnIdServerGroup = "id_server_group";
        #endregion
    }
}
