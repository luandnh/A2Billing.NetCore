using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcDidDestinationMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcDidDestination>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcDidDestination> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_did_destination");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Destination)
                .HasColumnName("destination")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasColumnName("priority")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdCcDid)
                .IsRequired()
                .HasColumnName("id_cc_did")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Secondusedreal)
                .HasColumnName("secondusedreal")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.VoipCall)
                .HasColumnName("voip_call")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Validated)
                .HasColumnName("validated")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_did_destination";

        public const string ColumnId = "id";
        public const string ColumnDestination = "destination";
        public const string ColumnPriority = "priority";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnIdCcDid = "id_cc_did";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnActivated = "activated";
        public const string ColumnSecondusedreal = "secondusedreal";
        public const string ColumnVoipCall = "voip_call";
        public const string ColumnValidated = "validated";
        #endregion
    }
}
