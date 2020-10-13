using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPackageOfferMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPackageOffer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPackageOffer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_package_offer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Label)
                .IsRequired()
                .HasColumnName("label")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Packagetype)
                .IsRequired()
                .HasColumnName("packagetype")
                .HasColumnType("int(11)");

            builder.Property(t => t.Billingtype)
                .IsRequired()
                .HasColumnName("billingtype")
                .HasColumnType("int(11)");

            builder.Property(t => t.Startday)
                .IsRequired()
                .HasColumnName("startday")
                .HasColumnType("int(11)");

            builder.Property(t => t.Freetimetocall)
                .IsRequired()
                .HasColumnName("freetimetocall")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_package_offer";

        public const string ColumnId = "id";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnLabel = "label";
        public const string ColumnPackagetype = "packagetype";
        public const string ColumnBillingtype = "billingtype";
        public const string ColumnStartday = "startday";
        public const string ColumnFreetimetocall = "freetimetocall";
        #endregion
    }
}
