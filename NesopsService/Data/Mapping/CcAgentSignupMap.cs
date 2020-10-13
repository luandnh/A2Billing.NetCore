using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAgentSignupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAgentSignup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAgentSignup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_agent_signup");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdAgent)
                .IsRequired()
                .HasColumnName("id_agent")
                .HasColumnType("int(11)");

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("code")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IdTariffgroup)
                .IsRequired()
                .HasColumnName("id_tariffgroup")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdGroup)
                .IsRequired()
                .HasColumnName("id_group")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_agent_signup";

        public const string ColumnId = "id";
        public const string ColumnIdAgent = "id_agent";
        public const string ColumnCode = "code";
        public const string ColumnIdTariffgroup = "id_tariffgroup";
        public const string ColumnIdGroup = "id_group";
        #endregion
    }
}
