using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardGroupMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCardGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCardGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_card_group");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                //.HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("varchar(400)")
                .HasMaxLength(400);

            builder.Property(t => t.UsersPerms)
                .IsRequired()
                .HasColumnName("users_perms")
                .HasColumnType("int(11)");

            builder.Property(t => t.IdAgent)
                .HasColumnName("id_agent")
                .HasColumnType("int(11)");

            builder.Property(t => t.Provisioning)
                .HasColumnName("provisioning")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_card_group";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnDescription = "description";
        public const string ColumnUsersPerms = "users_perms";
        public const string ColumnIdAgent = "id_agent";
        public const string ColumnProvisioning = "provisioning";
        #endregion
    }
}
