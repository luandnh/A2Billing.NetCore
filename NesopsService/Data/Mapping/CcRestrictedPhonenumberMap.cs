using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcRestrictedPhonenumberMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcRestrictedPhonenumber>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcRestrictedPhonenumber> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_restricted_phonenumber");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Number)
                .IsRequired()
                .HasColumnName("number")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_restricted_phonenumber";

        public const string ColumnId = "id";
        public const string ColumnNumber = "number";
        public const string ColumnIdCard = "id_card";
        #endregion
    }
}
