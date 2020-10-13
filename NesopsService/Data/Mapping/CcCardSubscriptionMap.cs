using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardSubscriptionMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCardSubscription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCardSubscription> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_card_subscription");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdSubscriptionFee)
                .HasColumnName("id_subscription_fee")
                .HasColumnType("int(11)");

            builder.Property(t => t.Startdate)
                .IsRequired()
                .HasColumnName("startdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Stopdate)
                .IsRequired()
                .HasColumnName("stopdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.ProductId)
                .HasColumnName("product_id")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ProductName)
                .HasColumnName("product_name")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.PaidStatus)
                .IsRequired()
                .HasColumnName("paid_status")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.LastRun)
                .IsRequired()
                .HasColumnName("last_run")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.NextBillingDate)
                .IsRequired()
                .HasColumnName("next_billing_date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.LimitPayDate)
                .IsRequired()
                .HasColumnName("limit_pay_date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_card_subscription";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnIdSubscriptionFee = "id_subscription_fee";
        public const string ColumnStartdate = "startdate";
        public const string ColumnStopdate = "stopdate";
        public const string ColumnProductId = "product_id";
        public const string ColumnProductName = "product_name";
        public const string ColumnPaidStatus = "paid_status";
        public const string ColumnLastRun = "last_run";
        public const string ColumnNextBillingDate = "next_billing_date";
        public const string ColumnLimitPayDate = "limit_pay_date";
        #endregion
    }
}
