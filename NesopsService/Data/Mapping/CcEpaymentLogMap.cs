using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcEpaymentLogMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcEpaymentLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcEpaymentLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_epayment_log");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Cardid)
                .IsRequired()
                .HasColumnName("cardid")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Vat)
                .IsRequired()
                .HasColumnName("vat")
                .HasColumnType("float");

            builder.Property(t => t.Paymentmethod)
                .IsRequired()
                .HasColumnName("paymentmethod")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CcOwner)
                .HasColumnName("cc_owner")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.CcNumber)
                .HasColumnName("cc_number")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CcExpires)
                .HasColumnName("cc_expires")
                .HasColumnType("varchar(7)")
                .HasMaxLength(7);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)");

            builder.Property(t => t.Cvv)
                .HasColumnName("cvv")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.CreditCardType)
                .HasColumnName("credit_card_type")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Currency)
                .HasColumnName("currency")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.TransactionDetail)
                .HasColumnName("transaction_detail")
                .HasColumnType("longtext");

            builder.Property(t => t.ItemType)
                .HasColumnName("item_type")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ItemId)
                .HasColumnName("item_id")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_epayment_log";

        public const string ColumnId = "id";
        public const string ColumnCardid = "cardid";
        public const string ColumnAmount = "amount";
        public const string ColumnVat = "vat";
        public const string ColumnPaymentmethod = "paymentmethod";
        public const string ColumnCcOwner = "cc_owner";
        public const string ColumnCcNumber = "cc_number";
        public const string ColumnCcExpires = "cc_expires";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnStatus = "status";
        public const string ColumnCvv = "cvv";
        public const string ColumnCreditCardType = "credit_card_type";
        public const string ColumnCurrency = "currency";
        public const string ColumnTransactionDetail = "transaction_detail";
        public const string ColumnItemType = "item_type";
        public const string ColumnItemId = "item_id";
        #endregion
    }
}
