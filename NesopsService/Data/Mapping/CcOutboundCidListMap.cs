using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcOutboundCidListMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcOutboundCidList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcOutboundCidList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_outbound_cid_list");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OutboundCidGroup)
                .IsRequired()
                .HasColumnName("outbound_cid_group")
                .HasColumnType("int(11)");

            builder.Property(t => t.Cid)
                .HasColumnName("cid")
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("int(11)");

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
        public const string TableName = "cc_outbound_cid_list";

        public const string ColumnId = "id";
        public const string ColumnOutboundCidGroup = "outbound_cid_group";
        public const string ColumnCid = "cid";
        public const string ColumnActivated = "activated";
        public const string ColumnCreationdate = "creationdate";
        #endregion
    }
}
