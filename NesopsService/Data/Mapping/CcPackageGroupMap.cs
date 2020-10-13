using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPackageGroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPackageGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPackageGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_package_group");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_package_group";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnDescription = "description";
        #endregion
    }
}
