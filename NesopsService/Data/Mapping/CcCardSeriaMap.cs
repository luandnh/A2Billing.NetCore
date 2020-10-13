using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardSeriaMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCardSeria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCardSeria> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_card_seria");

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

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("value")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_card_seria";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnDescription = "description";
        public const string ColumnValue = "value";
        #endregion
    }
}
