using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTicketCommentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTicketComment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTicketComment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_ticket_comment");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Date)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.IdTicket)
                .IsRequired()
                .HasColumnName("id_ticket")
                .HasColumnType("bigint(10)");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("text");

            builder.Property(t => t.Creator)
                .IsRequired()
                .HasColumnName("creator")
                .HasColumnType("bigint(20)");

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
        public const string TableName = "cc_ticket_comment";

        public const string ColumnId = "id";
        public const string ColumnDate = "date";
        public const string ColumnIdTicket = "id_ticket";
        public const string ColumnDescription = "description";
        public const string ColumnCreator = "creator";
        public const string ColumnCreatorType = "creator_type";
        public const string ColumnViewedCust = "viewed_cust";
        public const string ColumnViewedAgent = "viewed_agent";
        public const string ColumnViewedAdmin = "viewed_admin";
        #endregion
    }
}
