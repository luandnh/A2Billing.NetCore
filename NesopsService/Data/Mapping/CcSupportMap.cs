using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSupportMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSupport>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSupport> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_support");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("smallint(5)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Language)
                .IsRequired()
                .HasColumnName("language")
                .HasColumnType("char(5)")
                .HasMaxLength(5)
                .HasDefaultValueSql("'en'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_support";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnEmail = "email";
        public const string ColumnLanguage = "language";
        #endregion
    }
}
