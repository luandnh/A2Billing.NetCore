using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSubscriptionSignupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSubscriptionSignup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSubscriptionSignup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_subscription_signup");

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

            builder.Property(t => t.IdSubscription)
                .HasColumnName("id_subscription")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Enable)
                .IsRequired()
                .HasColumnName("enable")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.IdCallplan)
                .HasColumnName("id_callplan")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_subscription_signup";

        public const string ColumnId = "id";
        public const string ColumnLabel = "label";
        public const string ColumnIdSubscription = "id_subscription";
        public const string ColumnDescription = "description";
        public const string ColumnEnable = "enable";
        public const string ColumnIdCallplan = "id_callplan";
        #endregion
    }
}
