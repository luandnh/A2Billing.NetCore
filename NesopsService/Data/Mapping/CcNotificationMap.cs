using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcNotificationMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcNotification>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcNotification> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_notification");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.KeyValue)
                .HasColumnName("key_value")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasColumnName("priority")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.FromType)
                .IsRequired()
                .HasColumnName("from_type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.FromId)
                .HasColumnName("from_id")
                .HasColumnType("bigint(20)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.LinkId)
                .HasColumnName("link_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.LinkType)
                .HasColumnName("link_type")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_notification";

        public const string ColumnId = "id";
        public const string ColumnKeyValue = "key_value";
        public const string ColumnDate = "date";
        public const string ColumnPriority = "priority";
        public const string ColumnFromType = "from_type";
        public const string ColumnFromId = "from_id";
        public const string ColumnLinkId = "link_id";
        public const string ColumnLinkType = "link_type";
        #endregion
    }
}
