using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcStatusLogMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcStatusLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcStatusLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_status_log");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.UpdatedDate)
                .IsRequired()
                .HasColumnName("updated_date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_status_log";

        public const string ColumnId = "id";
        public const string ColumnStatus = "status";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnUpdatedDate = "updated_date";
        #endregion
    }
}
