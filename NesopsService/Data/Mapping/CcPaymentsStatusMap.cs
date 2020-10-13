using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPaymentsStatusMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPaymentsStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPaymentsStatus> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_payments_status");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.StatusId)
                .IsRequired()
                .HasColumnName("status_id")
                .HasColumnType("int(11)");

            builder.Property(t => t.StatusName)
                .IsRequired()
                .HasColumnName("status_name")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_payments_status";

        public const string ColumnId = "id";
        public const string ColumnStatusId = "status_id";
        public const string ColumnStatusName = "status_name";
        #endregion
    }
}
