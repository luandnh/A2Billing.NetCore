using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSystemLogMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSystemLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSystemLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_system_log");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Iduser)
                .IsRequired()
                .HasColumnName("iduser")
                .HasColumnType("int(11)");

            builder.Property(t => t.Loglevel)
                .IsRequired()
                .HasColumnName("loglevel")
                .HasColumnType("int(11)");

            builder.Property(t => t.Action)
                .IsRequired()
                .HasColumnName("action")
                .HasColumnType("text");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.Data)
                .HasColumnName("data")
                .HasColumnType("blob");

            builder.Property(t => t.Tablename)
                .HasColumnName("tablename")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Pagename)
                .HasColumnName("pagename")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Ipaddress)
                .HasColumnName("ipaddress")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Agent)
                .HasColumnName("agent")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_system_log";

        public const string ColumnId = "id";
        public const string ColumnIduser = "iduser";
        public const string ColumnLoglevel = "loglevel";
        public const string ColumnAction = "action";
        public const string ColumnDescription = "description";
        public const string ColumnData = "data";
        public const string ColumnTablename = "tablename";
        public const string ColumnPagename = "pagename";
        public const string ColumnIpaddress = "ipaddress";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnAgent = "agent";
        #endregion
    }
}
