using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAlarmMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAlarm>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAlarm> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_alarm");

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
                .HasColumnType("text");

            builder.Property(t => t.Periode)
                .IsRequired()
                .HasColumnName("periode")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Maxvalue)
                .IsRequired()
                .HasColumnName("maxvalue")
                .HasColumnType("float");

            builder.Property(t => t.Minvalue)
                .IsRequired()
                .HasColumnName("minvalue")
                .HasColumnType("float")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.IdTrunk)
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)");

            builder.Property(t => t.Numberofrun)
                .IsRequired()
                .HasColumnName("numberofrun")
                .HasColumnType("int(11)");

            builder.Property(t => t.Numberofalarm)
                .IsRequired()
                .HasColumnName("numberofalarm")
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
                .HasColumnName("emailreport")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_alarm";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnPeriode = "periode";
        public const string ColumnType = "type";
        public const string ColumnMaxvalue = "maxvalue";
        public const string ColumnMinvalue = "minvalue";
        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnStatus = "status";
        public const string ColumnNumberofrun = "numberofrun";
        public const string ColumnNumberofalarm = "numberofalarm";
        public const string ColumnDatecreate = "datecreate";
        public const string ColumnDatelastrun = "datelastrun";
        public const string ColumnEmailreport = "emailreport";
        #endregion
    }
}
