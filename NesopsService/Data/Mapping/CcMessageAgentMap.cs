using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcMessageAgentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcMessageAgent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcMessageAgent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_message_agent");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdAgent)
                .IsRequired()
                .HasColumnName("id_agent")
                .HasColumnType("int(11)");

            builder.Property(t => t.Message)
                .HasColumnName("message")
                .HasColumnType("longtext");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.Logo)
                .IsRequired()
                .HasColumnName("logo")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.OrderDisplay)
                .IsRequired()
                .HasColumnName("order_display")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_message_agent";

        public const string ColumnId = "id";
        public const string ColumnIdAgent = "id_agent";
        public const string ColumnMessage = "message";
        public const string ColumnType = "type";
        public const string ColumnLogo = "logo";
        public const string ColumnOrderDisplay = "order_display";
        #endregion
    }
}
