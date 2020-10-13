using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCountryMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCountry>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCountry> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_country");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Countrycode)
                .IsRequired()
                .HasColumnName("countrycode")
                .HasColumnType("char(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Countryprefix)
                .IsRequired()
                .HasColumnName("countryprefix")
                .HasColumnType("char(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Countryname)
                .IsRequired()
                .HasColumnName("countryname")
                .HasColumnType("char(80)")
                .HasMaxLength(80);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_country";

        public const string ColumnId = "id";
        public const string ColumnCountrycode = "countrycode";
        public const string ColumnCountryprefix = "countryprefix";
        public const string ColumnCountryname = "countryname";
        #endregion
    }
}
