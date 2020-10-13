using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTariffgroupPlanMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTariffgroupPlan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTariffgroupPlan> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_tariffgroup_plan");

            // key
            builder.HasKey(t => new { t.Idtariffgroup, t.Idtariffplan });

            // properties
            builder.Property(t => t.Idtariffgroup)
                .IsRequired()
                .HasColumnName("idtariffgroup")
                .HasColumnType("int(11)");

            builder.Property(t => t.Idtariffplan)
                .IsRequired()
                .HasColumnName("idtariffplan")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_tariffgroup_plan";

        public const string ColumnIdtariffgroup = "idtariffgroup";
        public const string ColumnIdtariffplan = "idtariffplan";
        #endregion
    }
}
