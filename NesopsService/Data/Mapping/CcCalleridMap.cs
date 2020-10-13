using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCalleridMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCallerid>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCallerid> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_callerid");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Cid)
                .IsRequired()
                .HasColumnName("cid")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("char(1)")
                .HasMaxLength(1)
                .HasDefaultValueSql("'t'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_callerid";

        public const string ColumnId = "id";
        public const string ColumnCid = "cid";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnActivated = "activated";
        #endregion
    }
}
