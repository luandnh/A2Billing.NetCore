using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardPackageOfferMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCardPackageOffer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCardPackageOffer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_card_package_offer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdCcPackageOffer)
                .IsRequired()
                .HasColumnName("id_cc_package_offer")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.DateConsumption)
                .IsRequired()
                .HasColumnName("date_consumption")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.UsedSecondes)
                .IsRequired()
                .HasColumnName("used_secondes")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_card_package_offer";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnIdCcPackageOffer = "id_cc_package_offer";
        public const string ColumnDateConsumption = "date_consumption";
        public const string ColumnUsedSecondes = "used_secondes";
        #endregion
    }
}
