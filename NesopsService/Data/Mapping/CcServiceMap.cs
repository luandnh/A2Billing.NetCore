using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcServiceMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcService>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcService> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_service");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("float");

            builder.Property(t => t.Period)
                .IsRequired()
                .HasColumnName("period")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Rule)
                .IsRequired()
                .HasColumnName("rule")
                .HasColumnType("int(11)");

            builder.Property(t => t.Daynumber)
                .IsRequired()
                .HasColumnName("daynumber")
                .HasColumnType("int(11)");

            builder.Property(t => t.Stopmode)
                .IsRequired()
                .HasColumnName("stopmode")
                .HasColumnType("int(11)");

            builder.Property(t => t.Maxnumbercycle)
                .IsRequired()
                .HasColumnName("maxnumbercycle")
                .HasColumnType("int(11)");

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
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Totalcredit)
                .IsRequired()
                .HasColumnName("totalcredit")
                .HasColumnType("float");

            builder.Property(t => t.Totalcardperform)
                .IsRequired()
                .HasColumnName("totalcardperform")
                .HasColumnType("int(11)");

            builder.Property(t => t.OperateMode)
                .HasColumnName("operate_mode")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Dialplan)
                .HasColumnName("dialplan")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.UseGroup)
                .HasColumnName("use_group")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_service";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnAmount = "amount";
        public const string ColumnPeriod = "period";
        public const string ColumnRule = "rule";
        public const string ColumnDaynumber = "daynumber";
        public const string ColumnStopmode = "stopmode";
        public const string ColumnMaxnumbercycle = "maxnumbercycle";
        public const string ColumnStatus = "status";
        public const string ColumnNumberofrun = "numberofrun";
        public const string ColumnDatecreate = "datecreate";
        public const string ColumnDatelastrun = "datelastrun";
        public const string ColumnEmailreport = "emailreport";
        public const string ColumnTotalcredit = "totalcredit";
        public const string ColumnTotalcardperform = "totalcardperform";
        public const string ColumnOperateMode = "operate_mode";
        public const string ColumnDialplan = "dialplan";
        public const string ColumnUseGroup = "use_group";
        #endregion
    }
}
