using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcBillingCustomerMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcBillingCustomer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcBillingCustomer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_billing_customer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.IdInvoice)
                .IsRequired()
                .HasColumnName("id_invoice")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.StartDate)
                .HasColumnName("start_date")
                .HasColumnType("timestamp(6)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_billing_customer";

        public const string ColumnId = "id";
        public const string ColumnIdCard = "id_card";
        public const string ColumnDate = "date";
        public const string ColumnIdInvoice = "id_invoice";
        public const string ColumnStartDate = "start_date";
        #endregion
    }
}
