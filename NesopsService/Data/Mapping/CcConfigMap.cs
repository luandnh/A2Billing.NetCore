using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcConfigMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_config");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ConfigTitle)
                .HasColumnName("config_title")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ConfigKey)
                .HasColumnName("config_key")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ConfigValue)
                .HasColumnName("config_value")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.ConfigDescription)
                .HasColumnName("config_description")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.ConfigValuetype)
                .IsRequired()
                .HasColumnName("config_valuetype")
                .HasColumnType("int(11)");

            builder.Property(t => t.ConfigListvalues)
                .HasColumnName("config_listvalues")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ConfigGroupTitle)
                .IsRequired()
                .HasColumnName("config_group_title")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_config";

        public const string ColumnId = "id";
        public const string ColumnConfigTitle = "config_title";
        public const string ColumnConfigKey = "config_key";
        public const string ColumnConfigValue = "config_value";
        public const string ColumnConfigDescription = "config_description";
        public const string ColumnConfigValuetype = "config_valuetype";
        public const string ColumnConfigListvalues = "config_listvalues";
        public const string ColumnConfigGroupTitle = "config_group_title";
        #endregion
    }
}
