using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcMonitorMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcMonitor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcMonitor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_monitor");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Label)
                .IsRequired()
                .HasColumnName("label")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DialCode)
                .HasColumnName("dial_code")
                .HasColumnType("int(11)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.TextIntro)
                .HasColumnName("text_intro")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.QueryType)
                .IsRequired()
                .HasColumnName("query_type")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Query)
                .HasColumnName("query")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.ResultType)
                .IsRequired()
                .HasColumnName("result_type")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Enable)
                .IsRequired()
                .HasColumnName("enable")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_monitor";

        public const string ColumnId = "id";
        public const string ColumnLabel = "label";
        public const string ColumnDialCode = "dial_code";
        public const string ColumnDescription = "description";
        public const string ColumnTextIntro = "text_intro";
        public const string ColumnQueryType = "query_type";
        public const string ColumnQuery = "query";
        public const string ColumnResultType = "result_type";
        public const string ColumnEnable = "enable";
        #endregion
    }
}
