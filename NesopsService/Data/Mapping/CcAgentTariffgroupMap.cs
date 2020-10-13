using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAgentTariffgroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAgentTariffgroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAgentTariffgroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_agent_tariffgroup");

            // key
            builder.HasKey(t => new { t.IdAgent, t.IdTariffgroup });

            // properties
            builder.Property(t => t.IdAgent)
                .IsRequired()
                .HasColumnName("id_agent")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdTariffgroup)
                .IsRequired()
                .HasColumnName("id_tariffgroup")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_agent_tariffgroup";

        public const string ColumnIdAgent = "id_agent";
        public const string ColumnIdTariffgroup = "id_tariffgroup";
        #endregion
    }
}
