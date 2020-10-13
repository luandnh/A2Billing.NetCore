using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcLogrefillMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcLogrefill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcLogrefill> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_logrefill");

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

            builder.Property(t => t.Credit)
                .IsRequired()
                .HasColumnName("credit")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("card_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.RefillType)
                .IsRequired()
                .HasColumnName("refill_type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.AddedInvoice)
                .IsRequired()
                .HasColumnName("added_invoice")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.AgentId)
                .HasColumnName("agent_id")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_logrefill";

        public const string ColumnId = "id";
        public const string ColumnDate = "date";
        public const string ColumnCredit = "credit";
        public const string ColumnCardId = "card_id";
        public const string ColumnDescription = "description";
        public const string ColumnRefillType = "refill_type";
        public const string ColumnAddedInvoice = "added_invoice";
        public const string ColumnAgentId = "agent_id";
        #endregion
    }
}
