using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcServerGroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcServerGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcServerGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_server_group");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_server_group";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnDescription = "description";
        #endregion
    }
}
