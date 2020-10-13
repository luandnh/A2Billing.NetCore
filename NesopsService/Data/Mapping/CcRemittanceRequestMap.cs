using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcRemittanceRequestMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcRemittanceRequest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcRemittanceRequest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_remittance_request");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdAgent)
                .IsRequired()
                .HasColumnName("id_agent")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("tinyint(4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_remittance_request";

        public const string ColumnId = "id";
        public const string ColumnIdAgent = "id_agent";
        public const string ColumnAmount = "amount";
        public const string ColumnType = "type";
        public const string ColumnDate = "date";
        public const string ColumnStatus = "status";
        #endregion
    }
}
