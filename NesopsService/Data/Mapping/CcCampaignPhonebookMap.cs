using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCampaignPhonebookMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCampaignPhonebook>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCampaignPhonebook> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_campaign_phonebook");

            // key
            builder.HasKey(t => new { t.IdCampaign, t.IdPhonebook });

            // properties
            builder.Property(t => t.IdCampaign)
                .IsRequired()
                .HasColumnName("id_campaign")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdPhonebook)
                .IsRequired()
                .HasColumnName("id_phonebook")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_campaign_phonebook";

        public const string ColumnIdCampaign = "id_campaign";
        public const string ColumnIdPhonebook = "id_phonebook";
        #endregion
    }
}
