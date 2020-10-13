using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCampaignConfigMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCampaignConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCampaignConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_campaign_config");

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
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Flatrate)
                .IsRequired()
                .HasColumnName("flatrate")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Context)
                .IsRequired()
                .HasColumnName("context")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_campaign_config";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnFlatrate = "flatrate";
        public const string ColumnContext = "context";
        public const string ColumnDescription = "description";
        #endregion
    }
}
