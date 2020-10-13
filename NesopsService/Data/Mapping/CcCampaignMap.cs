using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCampaignMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCampaign>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCampaign> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_campaign");

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
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Startingdate)
                .IsRequired()
                .HasColumnName("startingdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Expirationdate)
                .IsRequired()
                .HasColumnName("expirationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Secondusedreal)
                .HasColumnName("secondusedreal")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.NbCallmade)
                .HasColumnName("nb_callmade")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Frequency)
                .IsRequired()
                .HasColumnName("frequency")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'20'");

            builder.Property(t => t.ForwardNumber)
                .HasColumnName("forward_number")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DailyStartTime)
                .IsRequired()
                .HasColumnName("daily_start_time")
                .HasColumnType("time")
                .HasDefaultValueSql("'10:00:00'");

            builder.Property(t => t.DailyStopTime)
                .IsRequired()
                .HasColumnName("daily_stop_time")
                .HasColumnType("time")
                .HasDefaultValueSql("'18:00:00'");

            builder.Property(t => t.Monday)
                .IsRequired()
                .HasColumnName("monday")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Tuesday)
                .IsRequired()
                .HasColumnName("tuesday")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Wednesday)
                .IsRequired()
                .HasColumnName("wednesday")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Thursday)
                .IsRequired()
                .HasColumnName("thursday")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Friday)
                .IsRequired()
                .HasColumnName("friday")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Saturday)
                .IsRequired()
                .HasColumnName("saturday")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.Sunday)
                .IsRequired()
                .HasColumnName("sunday")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.IdCidGroup)
                .IsRequired()
                .HasColumnName("id_cid_group")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCampaignConfig)
                .IsRequired()
                .HasColumnName("id_campaign_config")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_campaign";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnStartingdate = "startingdate";
        public const string ColumnExpirationdate = "expirationdate";
        public const string ColumnDescription = "description";
        public const string ColumnIdCard = "id_card";
        public const string ColumnSecondusedreal = "secondusedreal";
        public const string ColumnNbCallmade = "nb_callmade";
        public const string ColumnStatus = "status";
        public const string ColumnFrequency = "frequency";
        public const string ColumnForwardNumber = "forward_number";
        public const string ColumnDailyStartTime = "daily_start_time";
        public const string ColumnDailyStopTime = "daily_stop_time";
        public const string ColumnMonday = "monday";
        public const string ColumnTuesday = "tuesday";
        public const string ColumnWednesday = "wednesday";
        public const string ColumnThursday = "thursday";
        public const string ColumnFriday = "friday";
        public const string ColumnSaturday = "saturday";
        public const string ColumnSunday = "sunday";
        public const string ColumnIdCidGroup = "id_cid_group";
        public const string ColumnIdCampaignConfig = "id_campaign_config";
        #endregion
    }
}
