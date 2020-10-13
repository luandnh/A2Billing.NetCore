using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSubscriptionServiceMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSubscriptionService>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSubscriptionService> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_subscription_service");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Label)
                .IsRequired()
                .HasColumnName("label")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Fee)
                .IsRequired()
                .HasColumnName("fee")
                .HasColumnType("float");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)");

            builder.Property(t => t.Numberofrun)
                .IsRequired()
                .HasColumnName("numberofrun")
                .HasColumnType("int(11)");

            builder.Property(t => t.Datecreate)
                .IsRequired()
                .HasColumnName("datecreate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Datelastrun)
                .IsRequired()
                .HasColumnName("datelastrun")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Emailreport)
                .IsRequired()
                .HasColumnName("emailreport")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Totalcredit)
                .IsRequired()
                .HasColumnName("totalcredit")
                .HasColumnType("float");

            builder.Property(t => t.Totalcardperform)
                .IsRequired()
                .HasColumnName("totalcardperform")
                .HasColumnType("int(11)");

            builder.Property(t => t.Startdate)
                .IsRequired()
                .HasColumnName("startdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Stopdate)
                .IsRequired()
                .HasColumnName("stopdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_subscription_service";

        public const string ColumnId = "id";
        public const string ColumnLabel = "label";
        public const string ColumnFee = "fee";
        public const string ColumnStatus = "status";
        public const string ColumnNumberofrun = "numberofrun";
        public const string ColumnDatecreate = "datecreate";
        public const string ColumnDatelastrun = "datelastrun";
        public const string ColumnEmailreport = "emailreport";
        public const string ColumnTotalcredit = "totalcredit";
        public const string ColumnTotalcardperform = "totalcardperform";
        public const string ColumnStartdate = "startdate";
        public const string ColumnStopdate = "stopdate";
        #endregion
    }
}
