using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcPhonenumberMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcPhonenumber>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcPhonenumber> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_phonenumber");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdPhonebook)
                .IsRequired()
                .HasColumnName("id_phonebook")
                .HasColumnType("int(11)");

            builder.Property(t => t.Number)
                .IsRequired()
                .HasColumnName("number")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("char(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("smallint(6)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Info)
                .HasColumnName("info")
                .HasColumnType("mediumtext");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_phonenumber";

        public const string ColumnId = "id";
        public const string ColumnIdPhonebook = "id_phonebook";
        public const string ColumnNumber = "number";
        public const string ColumnName = "name";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnStatus = "status";
        public const string ColumnInfo = "info";
        public const string ColumnAmount = "amount";
        #endregion
    }
}
