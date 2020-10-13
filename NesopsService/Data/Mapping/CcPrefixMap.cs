using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPrefixMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPrefix>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPrefix> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_prefix");

            // key
            builder.HasKey(t => t.Prefix);

            // properties
            builder.Property(t => t.Prefix)
                .IsRequired()
                .HasColumnName("prefix")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Destination)
                .IsRequired()
                .HasColumnName("destination")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_prefix";

        public const string ColumnPrefix = "prefix";
        public const string ColumnDestination = "destination";
        #endregion
    }
}
