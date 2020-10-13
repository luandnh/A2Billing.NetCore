using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcProviderMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcProvider>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcProvider> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_provider");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ProviderName)
                .IsRequired()
                .HasColumnName("provider_name")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_provider";

        public const string ColumnId = "id";
        public const string ColumnProviderName = "provider_name";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnDescription = "description";
        #endregion
    }
}
