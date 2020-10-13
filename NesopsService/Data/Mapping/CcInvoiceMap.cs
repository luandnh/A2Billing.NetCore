using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcInvoiceMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcInvoice>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcInvoice> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_invoice");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Reference)
                .HasColumnName("reference")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.PaidStatus)
                .IsRequired()
                .HasColumnName("paid_status")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_invoice";

        public const string ColumnId = "id";
        public const string ColumnReference = "reference";
        public const string ColumnIdCard = "id_card";
        public const string ColumnDate = "date";
        public const string ColumnPaidStatus = "paid_status";
        public const string ColumnStatus = "status";
        public const string ColumnTitle = "title";
        public const string ColumnDescription = "description";
        #endregion
    }
}
