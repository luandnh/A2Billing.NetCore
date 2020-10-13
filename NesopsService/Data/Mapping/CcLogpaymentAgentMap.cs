using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcLogpaymentAgentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcLogpaymentAgent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcLogpaymentAgent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_logpayment_agent");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Payment)
                .IsRequired()
                .HasColumnName("payment")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AgentId)
                .IsRequired()
                .HasColumnName("agent_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdLogrefill)
                .HasColumnName("id_logrefill")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.AddedRefill)
                .IsRequired()
                .HasColumnName("added_refill")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.PaymentType)
                .IsRequired()
                .HasColumnName("payment_type")
                .HasColumnType("tinyint(4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_logpayment_agent";

        public const string ColumnId = "id";
        public const string ColumnDate = "date";
        public const string ColumnPayment = "payment";
        public const string ColumnAgentId = "agent_id";
        public const string ColumnIdLogrefill = "id_logrefill";
        public const string ColumnDescription = "description";
        public const string ColumnAddedRefill = "added_refill";
        public const string ColumnPaymentType = "payment_type";
        #endregion
    }
}
