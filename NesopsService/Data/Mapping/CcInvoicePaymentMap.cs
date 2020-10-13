using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcInvoicePaymentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcInvoicePayment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcInvoicePayment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_invoice_payment");

            // key
            builder.HasKey(t => new { t.IdInvoice, t.IdPayment });

            // properties
            builder.Property(t => t.IdInvoice)
                .IsRequired()
                .HasColumnName("id_invoice")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdPayment)
                .IsRequired()
                .HasColumnName("id_payment")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_invoice_payment";

        public const string ColumnIdInvoice = "id_invoice";
        public const string ColumnIdPayment = "id_payment";
        #endregion
    }
}
