using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPackageRateMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPackageRate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPackageRate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_package_rate");

            // key
            builder.HasKey(t => new { t.PackageId, t.RateId });

            // properties
            builder.Property(t => t.PackageId)
                .IsRequired()
                .HasColumnName("package_id")
                .HasColumnType("int(11)");

            builder.Property(t => t.RateId)
                .IsRequired()
                .HasColumnName("rate_id")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_package_rate";

        public const string ColumnPackageId = "package_id";
        public const string ColumnRateId = "rate_id";
        #endregion
    }
}
