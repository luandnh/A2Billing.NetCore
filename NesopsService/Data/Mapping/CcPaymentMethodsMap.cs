using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPaymentMethodsMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPaymentMethods>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPaymentMethods> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_payment_methods");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.PaymentMethod)
                .IsRequired()
                .HasColumnName("payment_method")
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.PaymentFilename)
                .IsRequired()
                .HasColumnName("payment_filename")
                .HasColumnType("char(200)")
                .HasMaxLength(200);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_payment_methods";

        public const string ColumnId = "id";
        public const string ColumnPaymentMethod = "payment_method";
        public const string ColumnPaymentFilename = "payment_filename";
        #endregion
    }
}
