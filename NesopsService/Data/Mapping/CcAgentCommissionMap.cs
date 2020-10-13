using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAgentCommissionMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAgentCommission>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAgentCommission> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_agent_commission");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdPayment)
                .HasColumnName("id_payment")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdAgent)
                .IsRequired()
                .HasColumnName("id_agent")
                .HasColumnType("int(11)");

            builder.Property(t => t.CommissionType)
                .IsRequired()
                .HasColumnName("commission_type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.CommissionPercent)
                .IsRequired()
                .HasColumnName("commission_percent")
                .HasColumnType("decimal(10,4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_agent_commission";

        public const string ColumnId = "id";
        public const string ColumnIdPayment = "id_payment";
        public const string ColumnIdCard = "id_card";
        public const string ColumnDate = "date";
        public const string ColumnAmount = "amount";
        public const string ColumnDescription = "description";
        public const string ColumnIdAgent = "id_agent";
        public const string ColumnCommissionType = "commission_type";
        public const string ColumnCommissionPercent = "commission_percent";
        #endregion
    }
}
