using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCallArchiveMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCallArchive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCallArchive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_call_archive");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Sessionid)
                .IsRequired()
                .HasColumnName("sessionid")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Uniqueid)
                .IsRequired()
                .HasColumnName("uniqueid")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("card_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Nasipaddress)
                .IsRequired()
                .HasColumnName("nasipaddress")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Starttime)
                .IsRequired()
                .HasColumnName("starttime")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Stoptime)
                .IsRequired()
                .HasColumnName("stoptime")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Sessiontime)
                .HasColumnName("sessiontime")
                .HasColumnType("int(11)");

            builder.Property(t => t.Calledstation)
                .IsRequired()
                .HasColumnName("calledstation")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Sessionbill)
                .HasColumnName("sessionbill")
                .HasColumnType("float");

            builder.Property(t => t.IdTariffgroup)
                .HasColumnName("id_tariffgroup")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdTariffplan)
                .HasColumnName("id_tariffplan")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdRatecard)
                .HasColumnName("id_ratecard")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdTrunk)
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)");

            builder.Property(t => t.Sipiax)
                .HasColumnName("sipiax")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Src)
                .IsRequired()
                .HasColumnName("src")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.IdDid)
                .HasColumnName("id_did")
                .HasColumnType("int(11)");

            builder.Property(t => t.Buycost)
                .HasColumnName("buycost")
                .HasColumnType("decimal(15,5)")
                .HasDefaultValueSql("'0.00000'");

            builder.Property(t => t.IdCardPackageOffer)
                .HasColumnName("id_card_package_offer")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.RealSessiontime)
                .HasColumnName("real_sessiontime")
                .HasColumnType("int(11)");

            builder.Property(t => t.Dnid)
                .IsRequired()
                .HasColumnName("dnid")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Terminatecauseid)
                .HasColumnName("terminatecauseid")
                .HasColumnType("int(1)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Destination)
                .HasColumnName("destination")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_call_archive";

        public const string ColumnId = "id";
        public const string ColumnSessionid = "sessionid";
        public const string ColumnUniqueid = "uniqueid";
        public const string ColumnCardId = "card_id";
        public const string ColumnNasipaddress = "nasipaddress";
        public const string ColumnStarttime = "starttime";
        public const string ColumnStoptime = "stoptime";
        public const string ColumnSessiontime = "sessiontime";
        public const string ColumnCalledstation = "calledstation";
        public const string ColumnSessionbill = "sessionbill";
        public const string ColumnIdTariffgroup = "id_tariffgroup";
        public const string ColumnIdTariffplan = "id_tariffplan";
        public const string ColumnIdRatecard = "id_ratecard";
        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnSipiax = "sipiax";
        public const string ColumnSrc = "src";
        public const string ColumnIdDid = "id_did";
        public const string ColumnBuycost = "buycost";
        public const string ColumnIdCardPackageOffer = "id_card_package_offer";
        public const string ColumnRealSessiontime = "real_sessiontime";
        public const string ColumnDnid = "dnid";
        public const string ColumnTerminatecauseid = "terminatecauseid";
        public const string ColumnDestination = "destination";
        #endregion
    }
}
