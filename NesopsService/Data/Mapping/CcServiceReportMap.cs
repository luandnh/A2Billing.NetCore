using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcServiceReportMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcServiceReport>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcServiceReport> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_service_report");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CcServiceId)
                .IsRequired()
                .HasColumnName("cc_service_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Daterun)
                .IsRequired()
                .HasColumnName("daterun")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Totalcardperform)
                .HasColumnName("totalcardperform")
                .HasColumnType("int(11)");

            builder.Property(t => t.Totalcredit)
                .HasColumnName("totalcredit")
                .HasColumnType("float");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_service_report";

        public const string ColumnId = "id";
        public const string ColumnCcServiceId = "cc_service_id";
        public const string ColumnDaterun = "daterun";
        public const string ColumnTotalcardperform = "totalcardperform";
        public const string ColumnTotalcredit = "totalcredit";
        #endregion
    }
}
