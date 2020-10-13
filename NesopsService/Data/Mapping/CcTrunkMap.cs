using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTrunkMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTrunk>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTrunk> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_trunk");

            // key
            builder.HasKey(t => t.IdTrunk);

            // properties
            builder.Property(t => t.IdTrunk)
                .IsRequired()
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Trunkcode)
                .HasColumnName("trunkcode")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Trunkprefix)
                .HasColumnName("trunkprefix")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Providertech)
                .IsRequired()
                .HasColumnName("providertech")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Providerip)
                .IsRequired()
                .HasColumnName("providerip")
                .HasColumnType("char(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Removeprefix)
                .HasColumnName("removeprefix")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Secondusedreal)
                .HasColumnName("secondusedreal")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Secondusedcarrier)
                .HasColumnName("secondusedcarrier")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Secondusedratecard)
                .HasColumnName("secondusedratecard")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.FailoverTrunk)
                .HasColumnName("failover_trunk")
                .HasColumnType("int(11)");

            builder.Property(t => t.Addparameter)
                .HasColumnName("addparameter")
                .HasColumnType("char(120)")
                .HasMaxLength(120);

            builder.Property(t => t.IdProvider)
                .HasColumnName("id_provider")
                .HasColumnType("int(11)");

            builder.Property(t => t.Inuse)
                .HasColumnName("inuse")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Maxuse)
                .HasColumnName("maxuse")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.Status)
                .HasColumnName("status")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.IfMaxUse)
                .HasColumnName("if_max_use")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_trunk";

        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnTrunkcode = "trunkcode";
        public const string ColumnTrunkprefix = "trunkprefix";
        public const string ColumnProvidertech = "providertech";
        public const string ColumnProviderip = "providerip";
        public const string ColumnRemoveprefix = "removeprefix";
        public const string ColumnSecondusedreal = "secondusedreal";
        public const string ColumnSecondusedcarrier = "secondusedcarrier";
        public const string ColumnSecondusedratecard = "secondusedratecard";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnFailoverTrunk = "failover_trunk";
        public const string ColumnAddparameter = "addparameter";
        public const string ColumnIdProvider = "id_provider";
        public const string ColumnInuse = "inuse";
        public const string ColumnMaxuse = "maxuse";
        public const string ColumnStatus = "status";
        public const string ColumnIfMaxUse = "if_max_use";
        #endregion
    }
}
