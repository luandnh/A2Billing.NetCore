using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPaymentsAgentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPaymentsAgent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPaymentsAgent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_payments_agent");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AgentId)
                .IsRequired()
                .HasColumnName("agent_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.AgentName)
                .IsRequired()
                .HasColumnName("agent_name")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.AgentEmailAddress)
                .IsRequired()
                .HasColumnName("agent_email_address")
                .HasColumnType("varchar(96)")
                .HasMaxLength(96);

            builder.Property(t => t.ItemName)
                .HasColumnName("item_name")
                .HasColumnType("varchar(127)")
                .HasMaxLength(127);

            builder.Property(t => t.ItemId)
                .HasColumnName("item_id")
                .HasColumnType("varchar(127)")
                .HasMaxLength(127);

            builder.Property(t => t.ItemQuantity)
                .IsRequired()
                .HasColumnName("item_quantity")
                .HasColumnType("int(11)");

            builder.Property(t => t.PaymentMethod)
                .IsRequired()
                .HasColumnName("payment_method")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CcType)
                .HasColumnName("cc_type")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

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
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.OrdersStatus)
                .IsRequired()
                .HasColumnName("orders_status")
                .HasColumnType("int(5)");

            builder.Property(t => t.OrdersAmount)
                .HasColumnName("orders_amount")
                .HasColumnType("decimal(14,6)");

            builder.Property(t => t.LastModified)
                .HasColumnName("last_modified")
                .HasColumnType("datetime");

            builder.Property(t => t.DatePurchased)
                .HasColumnName("date_purchased")
                .HasColumnType("datetime");

            builder.Property(t => t.OrdersDateFinished)
                .HasColumnName("orders_date_finished")
                .HasColumnType("datetime");

            builder.Property(t => t.Currency)
                .HasColumnName("currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3);

            builder.Property(t => t.CurrencyValue)
                .HasColumnName("currency_value")
                .HasColumnType("decimal(14,6)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_payments_agent";

        public const string ColumnId = "id";
        public const string ColumnAgentId = "agent_id";
        public const string ColumnAgentName = "agent_name";
        public const string ColumnAgentEmailAddress = "agent_email_address";
        public const string ColumnItemName = "item_name";
        public const string ColumnItemId = "item_id";
        public const string ColumnItemQuantity = "item_quantity";
        public const string ColumnPaymentMethod = "payment_method";
        public const string ColumnCcType = "cc_type";
        public const string ColumnCcOwner = "cc_owner";
        public const string ColumnCcNumber = "cc_number";
        public const string ColumnCcExpires = "cc_expires";
        public const string ColumnOrdersStatus = "orders_status";
        public const string ColumnOrdersAmount = "orders_amount";
        public const string ColumnLastModified = "last_modified";
        public const string ColumnDatePurchased = "date_purchased";
        public const string ColumnOrdersDateFinished = "orders_date_finished";
        public const string ColumnCurrency = "currency";
        public const string ColumnCurrencyValue = "currency_value";
        #endregion
    }
}
