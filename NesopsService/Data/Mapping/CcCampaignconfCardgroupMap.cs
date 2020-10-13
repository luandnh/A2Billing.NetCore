using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCampaignconfCardgroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCampaignconfCardgroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCampaignconfCardgroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_campaignconf_cardgroup");

            // key
            builder.HasKey(t => new { t.IdCampaignConfig, t.IdCardGroup });

            // properties
            builder.Property(t => t.IdCampaignConfig)
                .IsRequired()
                .HasColumnName("id_campaign_config")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCardGroup)
                .IsRequired()
                .HasColumnName("id_card_group")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_campaignconf_cardgroup";

        public const string ColumnIdCampaignConfig = "id_campaign_config";
        public const string ColumnIdCardGroup = "id_card_group";
        #endregion
    }
}
