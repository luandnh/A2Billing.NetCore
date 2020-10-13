using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcSpeeddialMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcSpeeddial>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcSpeeddial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_speeddial");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Phone)
                .IsRequired()
                .HasColumnName("phone")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Speeddial)
                .HasColumnName("speeddial")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

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
        public const string TableName = "cc_speeddial";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnPhone = "phone";
        public const string ColumnName = "name";
        public const string ColumnSpeeddial = "speeddial";
        public const string ColumnCreationdate = "creationdate";
        #endregion
    }
}
