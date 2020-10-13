using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcAgentMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcAgent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcAgent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_agent");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Datecreation)
                .IsRequired()
                .HasColumnName("datecreation")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Active)
                .IsRequired()
                .HasColumnName("active")
                .HasColumnType("char(1)")
                .HasMaxLength(1)
                .HasDefaultValueSql("'f'");

            builder.Property(t => t.Login)
                .IsRequired()
                .HasColumnName("login")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Passwd)
                .HasColumnName("passwd")
                .HasColumnType("char(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Location)
                .HasColumnName("location")
                .HasColumnType("text");

            builder.Property(t => t.Language)
                .HasColumnName("language")
                .HasColumnType("char(5)")
                .HasMaxLength(5)
                .HasDefaultValueSql("'en'");

            builder.Property(t => t.IdTariffgroup)
                .HasColumnName("id_tariffgroup")
                .HasColumnType("int(11)");

            builder.Property(t => t.Options)
                .IsRequired()
                .HasColumnName("options")
                .HasColumnType("int(11)");

            builder.Property(t => t.Credit)
                .IsRequired()
                .HasColumnName("credit")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Currency)
                .HasColumnName("currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'USD'");

            builder.Property(t => t.Locale)
                .HasColumnName("locale")
                .HasColumnType("char(10)")
                .HasMaxLength(10)
                .HasDefaultValueSql("'C'");

            builder.Property(t => t.Commission)
                .IsRequired()
                .HasColumnName("commission")
                .HasColumnType("decimal(10,4)");

            builder.Property(t => t.Vat)
                .IsRequired()
                .HasColumnName("vat")
                .HasColumnType("decimal(10,4)");

            builder.Property(t => t.Banner)
                .HasColumnName("banner")
                .HasColumnType("text");

            builder.Property(t => t.Perms)
                .HasColumnName("perms")
                .HasColumnType("int(11)");

            builder.Property(t => t.Lastname)
                .HasColumnName("lastname")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Firstname)
                .HasColumnName("firstname")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.City)
                .HasColumnName("city")
                .HasColumnType("char(40)")
                .HasMaxLength(40);

            builder.Property(t => t.State)
                .HasColumnName("state")
                .HasColumnType("char(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Country)
                .HasColumnName("country")
                .HasColumnType("char(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Zipcode)
                .HasColumnName("zipcode")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Phone)
                .HasColumnName("phone")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Email)
                .HasColumnName("email")
                .HasColumnType("char(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Fax)
                .HasColumnName("fax")
                .HasColumnType("char(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Company)
                .HasColumnName("company")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ComBalance)
                .IsRequired()
                .HasColumnName("com_balance")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.ThresholdRemittance)
                .IsRequired()
                .HasColumnName("threshold_remittance")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.BankInfo)
                .HasColumnName("bank_info")
                .HasColumnType("mediumtext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_agent";

        public const string ColumnId = "id";
        public const string ColumnDatecreation = "datecreation";
        public const string ColumnActive = "active";
        public const string ColumnLogin = "login";
        public const string ColumnPasswd = "passwd";
        public const string ColumnLocation = "location";
        public const string ColumnLanguage = "language";
        public const string ColumnIdTariffgroup = "id_tariffgroup";
        public const string ColumnOptions = "options";
        public const string ColumnCredit = "credit";
        public const string ColumnCurrency = "currency";
        public const string ColumnLocale = "locale";
        public const string ColumnCommission = "commission";
        public const string ColumnVat = "vat";
        public const string ColumnBanner = "banner";
        public const string ColumnPerms = "perms";
        public const string ColumnLastname = "lastname";
        public const string ColumnFirstname = "firstname";
        public const string ColumnAddress = "address";
        public const string ColumnCity = "city";
        public const string ColumnState = "state";
        public const string ColumnCountry = "country";
        public const string ColumnZipcode = "zipcode";
        public const string ColumnPhone = "phone";
        public const string ColumnEmail = "email";
        public const string ColumnFax = "fax";
        public const string ColumnCompany = "company";
        public const string ColumnComBalance = "com_balance";
        public const string ColumnThresholdRemittance = "threshold_remittance";
        public const string ColumnBankInfo = "bank_info";
        #endregion
    }
}
