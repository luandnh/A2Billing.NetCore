using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcDidgroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcDidgroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcDidgroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_didgroup");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Didgroupname)
                .IsRequired()
                .HasColumnName("didgroupname")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

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
        public const string TableName = "cc_didgroup";

        public const string ColumnId = "id";
        public const string ColumnDidgroupname = "didgroupname";
        public const string ColumnCreationdate = "creationdate";
        #endregion
    }
}
