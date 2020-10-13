using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcNotificationAdminMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcNotificationAdmin>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcNotificationAdmin> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_notification_admin");

            // key
            builder.HasKey(t => new { t.IdNotification, t.IdAdmin });

            // properties
            builder.Property(t => t.IdNotification)
                .IsRequired()
                .HasColumnName("id_notification")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdAdmin)
                .IsRequired()
                .HasColumnName("id_admin")
                .HasColumnType("int(11)");

            builder.Property(t => t.Viewed)
                .IsRequired()
                .HasColumnName("viewed")
                .HasColumnType("tinyint(4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_notification_admin";

        public const string ColumnIdNotification = "id_notification";
        public const string ColumnIdAdmin = "id_admin";
        public const string ColumnViewed = "viewed";
        #endregion
    }
}
