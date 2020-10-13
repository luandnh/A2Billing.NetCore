using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPaypalMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPaypal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPaypal> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_paypal");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.PayerId)
                .HasColumnName("payer_id")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PaymentDate)
                .HasColumnName("payment_date")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TxnId)
                .HasColumnName("txn_id")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.PayerEmail)
                .HasColumnName("payer_email")
                .HasColumnType("varchar(55)")
                .HasMaxLength(55);

            builder.Property(t => t.PayerStatus)
                .HasColumnName("payer_status")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PaymentType)
                .HasColumnName("payment_type")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Memo)
                .HasColumnName("memo")
                .HasColumnType("tinytext");

            builder.Property(t => t.ItemName)
                .HasColumnName("item_name")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.ItemNumber)
                .HasColumnName("item_number")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("quantity")
                .HasColumnType("int(11)");

            builder.Property(t => t.McGross)
                .HasColumnName("mc_gross")
                .HasColumnType("decimal(9,2)");

            builder.Property(t => t.McFee)
                .HasColumnName("mc_fee")
                .HasColumnType("decimal(9,2)");

            builder.Property(t => t.Tax)
                .HasColumnName("tax")
                .HasColumnType("decimal(9,2)");

            builder.Property(t => t.McCurrency)
                .HasColumnName("mc_currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3);

            builder.Property(t => t.AddressName)
                .IsRequired()
                .HasColumnName("address_name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressStreet)
                .IsRequired()
                .HasColumnName("address_street")
                .HasColumnType("varchar(80)")
                .HasMaxLength(80)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressCity)
                .IsRequired()
                .HasColumnName("address_city")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressState)
                .IsRequired()
                .HasColumnName("address_state")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressZip)
                .IsRequired()
                .HasColumnName("address_zip")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressCountry)
                .IsRequired()
                .HasColumnName("address_country")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.Property(t => t.AddressStatus)
                .IsRequired()
                .HasColumnName("address_status")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.Property(t => t.PayerBusinessName)
                .IsRequired()
                .HasColumnName("payer_business_name")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40)
                .HasDefaultValueSql("''");

            builder.Property(t => t.PaymentStatus)
                .IsRequired()
                .HasColumnName("payment_status")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.Property(t => t.PendingReason)
                .IsRequired()
                .HasColumnName("pending_reason")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .HasDefaultValueSql("''");

            builder.Property(t => t.ReasonCode)
                .IsRequired()
                .HasColumnName("reason_code")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.Property(t => t.TxnType)
                .IsRequired()
                .HasColumnName("txn_type")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_paypal";

        public const string ColumnId = "id";
        public const string ColumnPayerId = "payer_id";
        public const string ColumnPaymentDate = "payment_date";
        public const string ColumnTxnId = "txn_id";
        public const string ColumnFirstName = "first_name";
        public const string ColumnLastName = "last_name";
        public const string ColumnPayerEmail = "payer_email";
        public const string ColumnPayerStatus = "payer_status";
        public const string ColumnPaymentType = "payment_type";
        public const string ColumnMemo = "memo";
        public const string ColumnItemName = "item_name";
        public const string ColumnItemNumber = "item_number";
        public const string ColumnQuantity = "quantity";
        public const string ColumnMcGross = "mc_gross";
        public const string ColumnMcFee = "mc_fee";
        public const string ColumnTax = "tax";
        public const string ColumnMcCurrency = "mc_currency";
        public const string ColumnAddressName = "address_name";
        public const string ColumnAddressStreet = "address_street";
        public const string ColumnAddressCity = "address_city";
        public const string ColumnAddressState = "address_state";
        public const string ColumnAddressZip = "address_zip";
        public const string ColumnAddressCountry = "address_country";
        public const string ColumnAddressStatus = "address_status";
        public const string ColumnPayerBusinessName = "payer_business_name";
        public const string ColumnPaymentStatus = "payment_status";
        public const string ColumnPendingReason = "pending_reason";
        public const string ColumnReasonCode = "reason_code";
        public const string ColumnTxnType = "txn_type";
        #endregion
    }
}
