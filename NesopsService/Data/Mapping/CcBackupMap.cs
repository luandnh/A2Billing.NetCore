using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcBackupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcBackup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcBackup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_backup");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Path)
                .IsRequired()
                .HasColumnName("path")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_backup";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnPath = "path";
        public const string ColumnCreationdate = "creationdate";
        #endregion
    }
}
