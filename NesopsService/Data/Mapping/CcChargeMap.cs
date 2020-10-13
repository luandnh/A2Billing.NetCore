using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcChargeMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCharge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCharge> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_charge");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcCard)
                .IsRequired()
                .HasColumnName("id_cc_card")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Iduser)
                .IsRequired()
                .HasColumnName("iduser")
                .HasColumnType("int(11)");

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("float");

            builder.Property(t => t.Chargetype)
                .HasColumnName("chargetype")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdCcDid)
                .HasColumnName("id_cc_did")
                .HasColumnType("bigint(20)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.IdCcCardSubscription)
                .HasColumnName("id_cc_card_subscription")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.CoverFrom)
                .HasColumnName("cover_from")
                .HasColumnType("date");

            builder.Property(t => t.CoverTo)
                .HasColumnName("cover_to")
                .HasColumnType("date");

            builder.Property(t => t.ChargedStatus)
                .IsRequired()
                .HasColumnName("charged_status")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.InvoicedStatus)
                .IsRequired()
                .HasColumnName("invoiced_status")
                .HasColumnType("tinyint(4)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_charge";

        public const string ColumnId = "id";
        public const string ColumnIdCcCard = "id_cc_card";
        public const string ColumnIduser = "iduser";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnAmount = "amount";
        public const string ColumnChargetype = "chargetype";
        public const string ColumnDescription = "description";
        public const string ColumnIdCcDid = "id_cc_did";
        public const string ColumnIdCcCardSubscription = "id_cc_card_subscription";
        public const string ColumnCoverFrom = "cover_from";
        public const string ColumnCoverTo = "cover_to";
        public const string ColumnChargedStatus = "charged_status";
        public const string ColumnInvoicedStatus = "invoiced_status";
        #endregion
    }
}
