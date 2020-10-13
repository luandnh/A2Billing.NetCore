using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcUiAuthenMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcUiAuthen>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcUiAuthen> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_ui_authen");

            // key
            builder.HasKey(t => t.Userid);

            // properties
            builder.Property(t => t.Userid)
                .IsRequired()
                .HasColumnName("userid")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Login)
                .IsRequired()
                .HasColumnName("login")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PwdEncoded)
                .IsRequired()
                .HasColumnName("pwd_encoded")
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Groupid)
                .HasColumnName("groupid")
                .HasColumnType("int(11)");

            builder.Property(t => t.Perms)
                .HasColumnName("perms")
                .HasColumnType("int(11)");

            builder.Property(t => t.Confaddcust)
                .HasColumnName("confaddcust")
                .HasColumnType("int(11)");

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Direction)
                .HasColumnName("direction")
                .HasColumnType("char(80)")
                .HasMaxLength(80);

            builder.Property(t => t.Zipcode)
                .HasColumnName("zipcode")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Phone)
                .HasColumnName("phone")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Fax)
                .HasColumnName("fax")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Datecreation)
                .IsRequired()
                .HasColumnName("datecreation")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Country)
                .HasColumnName("country")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.City)
                .HasColumnName("city")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_ui_authen";

        public const string ColumnUserid = "userid";
        public const string ColumnLogin = "login";
        public const string ColumnPwdEncoded = "pwd_encoded";
        public const string ColumnGroupid = "groupid";
        public const string ColumnPerms = "perms";
        public const string ColumnConfaddcust = "confaddcust";
        public const string ColumnName = "name";
        public const string ColumnDirection = "direction";
        public const string ColumnZipcode = "zipcode";
        public const string ColumnState = "state";
        public const string ColumnPhone = "phone";
        public const string ColumnFax = "fax";
        public const string ColumnDatecreation = "datecreation";
        public const string ColumnEmail = "email";
        public const string ColumnCountry = "country";
        public const string ColumnCity = "city";
        #endregion
    }
}
