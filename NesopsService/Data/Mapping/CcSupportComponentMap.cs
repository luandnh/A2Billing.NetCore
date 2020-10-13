using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSupportComponentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSupportComponent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSupportComponent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_support_component");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                //.HasColumnType("smallint(5)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdSupport)
                .IsRequired()
                .HasColumnName("id_support")
                .HasColumnType("smallint(5)");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("smallint(6)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.TypeUser)
                .IsRequired()
                .HasColumnName("type_user")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'2'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_support_component";

        public const string ColumnId = "id";
        public const string ColumnIdSupport = "id_support";
        public const string ColumnName = "name";
        public const string ColumnActivated = "activated";
        public const string ColumnTypeUser = "type_user";
        #endregion
    }
}
