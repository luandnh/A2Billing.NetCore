using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcIso639Map
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcIso639>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcIso639> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_iso639");

            // key
            builder.HasKey(t => t.Code);

            // properties
            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("code")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("char(16)")
                .HasMaxLength(16);

            builder.Property(t => t.Lname)
                .HasColumnName("lname")
                .HasColumnType("char(16)")
                .HasMaxLength(16);

            builder.Property(t => t.Charset)
                .IsRequired()
                .HasColumnName("charset")
                .HasColumnType("char(16)")
                .HasMaxLength(16)
                .HasDefaultValueSql("'ISO-8859-1'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_iso639";

        public const string ColumnCode = "code";
        public const string ColumnName = "name";
        public const string ColumnLname = "lname";
        public const string ColumnCharset = "charset";
        #endregion
    }
}
