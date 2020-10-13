using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcVersionMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcVersion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcVersion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_version");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Version)
                .IsRequired()
                .HasColumnName("version")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_version";

        public const string ColumnVersion = "version";
        #endregion
    }
}
