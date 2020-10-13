using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcVoucherMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcVoucher>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcVoucher> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_voucher");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Usedate)
                .IsRequired()
                .HasColumnName("usedate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Expirationdate)
                .IsRequired()
                .HasColumnName("expirationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Voucher)
                .IsRequired()
                .HasColumnName("voucher")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Usedcardnumber)
                .HasColumnName("usedcardnumber")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Tag)
                .HasColumnName("tag")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Credit)
                .IsRequired()
                .HasColumnName("credit")
                .HasColumnType("float");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("char(1)")
                .HasMaxLength(1)
                .HasDefaultValueSql("'f'");

            builder.Property(t => t.Used)
                .HasColumnName("used")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Currency)
                .HasColumnName("currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'USD'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_voucher";

        public const string ColumnId = "id";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnUsedate = "usedate";
        public const string ColumnExpirationdate = "expirationdate";
        public const string ColumnVoucher = "voucher";
        public const string ColumnUsedcardnumber = "usedcardnumber";
        public const string ColumnTag = "tag";
        public const string ColumnCredit = "credit";
        public const string ColumnActivated = "activated";
        public const string ColumnUsed = "used";
        public const string ColumnCurrency = "currency";
        #endregion
    }
}
