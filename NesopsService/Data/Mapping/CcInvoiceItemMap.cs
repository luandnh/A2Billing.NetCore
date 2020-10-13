using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcInvoiceItemMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcInvoiceItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcInvoiceItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_invoice_item");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdInvoice)
                .IsRequired()
                .HasColumnName("id_invoice")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnName("price")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Vat)
                .IsRequired()
                .HasColumnName("VAT")
                .HasColumnType("decimal(4,2)");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdExt)
                .HasColumnName("id_ext")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.TypeExt)
                .HasColumnName("type_ext")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_invoice_item";

        public const string ColumnId = "id";
        public const string ColumnIdInvoice = "id_invoice";
        public const string ColumnDate = "date";
        public const string ColumnPrice = "price";
        public const string ColumnVat = "VAT";
        public const string ColumnDescription = "description";
        public const string ColumnIdExt = "id_ext";
        public const string ColumnTypeExt = "type_ext";
        #endregion
    }
}
