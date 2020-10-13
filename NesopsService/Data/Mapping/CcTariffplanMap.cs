using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTariffplanMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTariffplan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTariffplan> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_tariffplan");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Iduser)
                .IsRequired()
                .HasColumnName("iduser")
                .HasColumnType("int(11)");

            builder.Property(t => t.Tariffname)
                .IsRequired()
                .HasColumnName("tariffname")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Startingdate)
                .IsRequired()
                .HasColumnName("startingdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Expirationdate)
                .IsRequired()
                .HasColumnName("expirationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdTrunk)
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Secondusedreal)
                .HasColumnName("secondusedreal")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Secondusedcarrier)
                .HasColumnName("secondusedcarrier")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Secondusedratecard)
                .HasColumnName("secondusedratecard")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Reftariffplan)
                .HasColumnName("reftariffplan")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Idowner)
                .HasColumnName("idowner")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Dnidprefix)
                .IsRequired()
                .HasColumnName("dnidprefix")
                .HasColumnType("char(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("'all'");

            builder.Property(t => t.Calleridprefix)
                .IsRequired()
                .HasColumnName("calleridprefix")
                .HasColumnType("char(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("'all'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_tariffplan";

        public const string ColumnId = "id";
        public const string ColumnIduser = "iduser";
        public const string ColumnTariffname = "tariffname";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnStartingdate = "startingdate";
        public const string ColumnExpirationdate = "expirationdate";
        public const string ColumnDescription = "description";
        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnSecondusedreal = "secondusedreal";
        public const string ColumnSecondusedcarrier = "secondusedcarrier";
        public const string ColumnSecondusedratecard = "secondusedratecard";
        public const string ColumnReftariffplan = "reftariffplan";
        public const string ColumnIdowner = "idowner";
        public const string ColumnDnidprefix = "dnidprefix";
        public const string ColumnCalleridprefix = "calleridprefix";
        #endregion
    }
}
