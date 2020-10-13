using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcInvoiceConfMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcInvoiceConf>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcInvoiceConf> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_invoice_conf");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.KeyVal)
                .IsRequired()
                .HasColumnName("key_val")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("value")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_invoice_conf";

        public const string ColumnId = "id";
        public const string ColumnKeyVal = "key_val";
        public const string ColumnValue = "value";
        #endregion
    }
}
