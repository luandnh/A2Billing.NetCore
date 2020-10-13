using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCampaignPhonestatusMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCampaignPhonestatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCampaignPhonestatus> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_campaign_phonestatus");

            // key
            builder.HasKey(t => new { t.IdPhonenumber, t.IdCampaign });

            // properties
            builder.Property(t => t.IdPhonenumber)
                .IsRequired()
                .HasColumnName("id_phonenumber")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdCampaign)
                .IsRequired()
                .HasColumnName("id_campaign")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCallback)
                .IsRequired()
                .HasColumnName("id_callback")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)");

            builder.Property(t => t.Lastuse)
                .IsRequired()
                .HasColumnName("lastuse")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_campaign_phonestatus";

        public const string ColumnIdPhonenumber = "id_phonenumber";
        public const string ColumnIdCampaign = "id_campaign";
        public const string ColumnIdCallback = "id_callback";
        public const string ColumnStatus = "status";
        public const string ColumnLastuse = "lastuse";
        #endregion
    }
}
