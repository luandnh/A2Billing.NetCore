using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTariffgroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTariffgroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTariffgroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_tariffgroup");

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

            builder.Property(t => t.Idtariffplan)
                .IsRequired()
                .HasColumnName("idtariffplan")
                .HasColumnType("int(11)");

            builder.Property(t => t.Tariffgroupname)
                .IsRequired()
                .HasColumnName("tariffgroupname")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Lcrtype)
                .IsRequired()
                .HasColumnName("lcrtype")
                .HasColumnType("int(11)");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Removeinterprefix)
                .IsRequired()
                .HasColumnName("removeinterprefix")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCcPackageOffer)
                .IsRequired()
                .HasColumnName("id_cc_package_offer")
                .HasColumnType("bigint(20)")
                .HasDefaultValueSql("'-1'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_tariffgroup";

        public const string ColumnId = "id";
        public const string ColumnIduser = "iduser";
        public const string ColumnIdtariffplan = "idtariffplan";
        public const string ColumnTariffgroupname = "tariffgroupname";
        public const string ColumnLcrtype = "lcrtype";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnRemoveinterprefix = "removeinterprefix";
        public const string ColumnIdCcPackageOffer = "id_cc_package_offer";
        #endregion
    }
}
