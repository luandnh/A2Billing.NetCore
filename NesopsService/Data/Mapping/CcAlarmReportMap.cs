using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAlarmReportMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAlarmReport>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAlarmReport> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_alarm_report");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CcAlarmId)
                .IsRequired()
                .HasColumnName("cc_alarm_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Calculatedvalue)
                .IsRequired()
                .HasColumnName("calculatedvalue")
                .HasColumnType("float");

            builder.Property(t => t.Daterun)
                .IsRequired()
                .HasColumnName("daterun")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_alarm_report";

        public const string ColumnId = "id";
        public const string ColumnCcAlarmId = "cc_alarm_id";
        public const string ColumnCalculatedvalue = "calculatedvalue";
        public const string ColumnDaterun = "daterun";
        #endregion
    }
}
