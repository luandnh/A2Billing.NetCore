using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcOutboundCidGroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcOutboundCidGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcOutboundCidGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_outbound_cid_group");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.GroupName)
                .IsRequired()
                .HasColumnName("group_name")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_outbound_cid_group";

        public const string ColumnId = "id";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnGroupName = "group_name";
        #endregion
    }
}
