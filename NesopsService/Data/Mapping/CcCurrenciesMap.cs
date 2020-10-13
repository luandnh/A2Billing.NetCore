using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCurrenciesMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCurrencies>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCurrencies> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_currencies");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("smallint(5) unsigned")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Currency)
                .IsRequired()
                .HasColumnName("currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("value")
                .HasColumnType("decimal(12,5)");

            builder.Property(t => t.Lastupdate)
                .IsRequired()
                .HasColumnName("lastupdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Basecurrency)
                .IsRequired()
                .HasColumnName("basecurrency")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'USD'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_currencies";

        public const string ColumnId = "id";
        public const string ColumnCurrency = "currency";
        public const string ColumnName = "name";
        public const string ColumnValue = "value";
        public const string ColumnLastupdate = "lastupdate";
        public const string ColumnBasecurrency = "basecurrency";
        #endregion
    }
}
