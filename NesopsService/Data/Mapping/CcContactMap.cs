using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcContactMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcContact>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcContact> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_contact");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CardId)
                .IsRequired()
                .HasColumnName("card_id")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Firstname)
                .HasColumnName("firstname")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Lastname)
                .HasColumnName("lastname")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Phonenumber)
                .IsRequired()
                .HasColumnName("phonenumber")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("active")
                .HasColumnType("bit(1)")
                .HasDefaultValueSql("b'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_contact";

        public const string ColumnId = "id";
        public const string ColumnCardId = "card_id";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnFirstname = "firstname";
        public const string ColumnLastname = "lastname";
        public const string ColumnPhonenumber = "phonenumber";
        public const string ColumnEmail = "email";
        public const string ColumnAddress = "address";
        public const string ColumnActive = "active";
        #endregion
    }
}
