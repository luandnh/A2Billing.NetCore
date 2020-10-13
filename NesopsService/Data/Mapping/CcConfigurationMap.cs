using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcConfigurationMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcConfiguration>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcConfiguration> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_configuration");

            // key
            builder.HasKey(t => t.ConfigurationId);

            // properties
            builder.Property(t => t.ConfigurationId)
                .IsRequired()
                .HasColumnName("configuration_id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ConfigurationTitle)
                .IsRequired()
                .HasColumnName("configuration_title")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.ConfigurationKey)
                .IsRequired()
                .HasColumnName("configuration_key")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.ConfigurationValue)
                .IsRequired()
                .HasColumnName("configuration_value")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ConfigurationDescription)
                .IsRequired()
                .HasColumnName("configuration_description")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ConfigurationType)
                .IsRequired()
                .HasColumnName("configuration_type")
                .HasColumnType("int(11)");

            builder.Property(t => t.UseFunction)
                .HasColumnName("use_function")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SetFunction)
                .HasColumnName("set_function")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_configuration";

        public const string ColumnConfigurationId = "configuration_id";
        public const string ColumnConfigurationTitle = "configuration_title";
        public const string ColumnConfigurationKey = "configuration_key";
        public const string ColumnConfigurationValue = "configuration_value";
        public const string ColumnConfigurationDescription = "configuration_description";
        public const string ColumnConfigurationType = "configuration_type";
        public const string ColumnUseFunction = "use_function";
        public const string ColumnSetFunction = "set_function";
        #endregion
    }
}
