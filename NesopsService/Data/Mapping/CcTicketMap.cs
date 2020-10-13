using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTicketMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTicket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTicket> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_ticket");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(10)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdComponent)
                .IsRequired()
                .HasColumnName("id_component")
                .HasColumnType("smallint(5)");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("text");

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasColumnName("priority")
                .HasColumnType("smallint(6)");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Creator)
                .IsRequired()
                .HasColumnName("creator")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("smallint(6)");

            builder.Property(t => t.CreatorType)
                .IsRequired()
                .HasColumnName("creator_type")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.ViewedCust)
                .IsRequired()
                .HasColumnName("viewed_cust")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.ViewedAgent)
                .IsRequired()
                .HasColumnName("viewed_agent")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.ViewedAdmin)
                .IsRequired()
                .HasColumnName("viewed_admin")
                .HasColumnType("tinyint(4)")
                .HasDefaultValueSql("'1'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_ticket";

        public const string ColumnId = "id";
        public const string ColumnIdComponent = "id_component";
        public const string ColumnTitle = "title";
        public const string ColumnDescription = "description";
        public const string ColumnPriority = "priority";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnCreator = "creator";
        public const string ColumnStatus = "status";
        public const string ColumnCreatorType = "creator_type";
        public const string ColumnViewedCust = "viewed_cust";
        public const string ColumnViewedAgent = "viewed_agent";
        public const string ColumnViewedAdmin = "viewed_admin";
        #endregion
    }
}
