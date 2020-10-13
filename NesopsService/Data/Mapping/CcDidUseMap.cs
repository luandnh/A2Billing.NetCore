using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcDidUseMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcDidUse>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcDidUse> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_did_use");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdDid)
                .IsRequired()
                .HasColumnName("id_did")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Reservationdate)
                .IsRequired()
                .HasColumnName("reservationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Releasedate)
                .IsRequired()
                .HasColumnName("releasedate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Activated)
                .HasColumnName("activated")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.MonthPayed)
                .HasColumnName("month_payed")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Reminded)
                .IsRequired()
                .HasColumnName("reminded")
                .HasColumnType("tinyint(4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_did_use";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnIdDid = "id_did";
        public const string ColumnReservationdate = "reservationdate";
        public const string ColumnReleasedate = "releasedate";
        public const string ColumnActivated = "activated";
        public const string ColumnMonthPayed = "month_payed";
        public const string ColumnReminded = "reminded";
        #endregion
    }
}
