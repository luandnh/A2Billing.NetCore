using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCallplanLcrMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCallplanLcr>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCallplanLcr> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("cc_callplan_lcr");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Destination)
                .HasColumnName("destination")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Dialprefix)
                .HasColumnName("dialprefix")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Buyrate)
                .HasColumnName("buyrate")
                .HasColumnType("decimal(15,5)")
                .HasDefaultValueSql("'0.00000'");

            builder.Property(t => t.Rateinitial)
                .HasColumnName("rateinitial")
                .HasColumnType("decimal(15,5)")
                .HasDefaultValueSql("'0.00000'");

            builder.Property(t => t.Startdate)
                .HasColumnName("startdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Stopdate)
                .HasColumnName("stopdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Initblock)
                .HasColumnName("initblock")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Connectcharge)
                .HasColumnName("connectcharge")
                .HasColumnType("decimal(15,5)")
                .HasDefaultValueSql("'0.00000'");

            builder.Property(t => t.IdTrunk)
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.Idtariffplan)
                .HasColumnName("idtariffplan")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.RatecardId)
                .HasColumnName("ratecard_id")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.TariffgroupId)
                .HasColumnName("tariffgroup_id")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_callplan_lcr";

        public const string ColumnId = "id";
        public const string ColumnDestination = "destination";
        public const string ColumnDialprefix = "dialprefix";
        public const string ColumnBuyrate = "buyrate";
        public const string ColumnRateinitial = "rateinitial";
        public const string ColumnStartdate = "startdate";
        public const string ColumnStopdate = "stopdate";
        public const string ColumnInitblock = "initblock";
        public const string ColumnConnectcharge = "connectcharge";
        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnIdtariffplan = "idtariffplan";
        public const string ColumnRatecardId = "ratecard_id";
        public const string ColumnTariffgroupId = "tariffgroup_id";
        #endregion
    }
}
