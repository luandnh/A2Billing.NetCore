using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcServerManagerMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcServerManager>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcServerManager> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_server_manager");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdGroup)
                .HasColumnName("id_group")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.ServerIp)
                .HasColumnName("server_ip")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.ManagerHost)
                .HasColumnName("manager_host")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ManagerUsername)
                .HasColumnName("manager_username")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ManagerSecret)
                .HasColumnName("manager_secret")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LasttimeUsed)
                .IsRequired()
                .HasColumnName("lasttime_used")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_server_manager";

        public const string ColumnId = "id";
        public const string ColumnIdGroup = "id_group";
        public const string ColumnServerIp = "server_ip";
        public const string ColumnManagerHost = "manager_host";
        public const string ColumnManagerUsername = "manager_username";
        public const string ColumnManagerSecret = "manager_secret";
        public const string ColumnLasttimeUsed = "lasttime_used";
        #endregion
    }
}
