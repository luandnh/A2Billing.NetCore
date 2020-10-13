using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardgroupServiceMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCardgroupService>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCardgroupService> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_cardgroup_service");

            // key
            builder.HasKey(t => new { t.IdCardGroup, t.IdService });

            // properties
            builder.Property(t => t.IdCardGroup)
                .IsRequired()
                .HasColumnName("id_card_group")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdService)
                .IsRequired()
                .HasColumnName("id_service")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_cardgroup_service";

        public const string ColumnIdCardGroup = "id_card_group";
        public const string ColumnIdService = "id_service";
        #endregion
    }
}
