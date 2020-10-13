using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcDidMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcDid>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcDid> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_did");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdCcDidgroup)
                .IsRequired()
                .HasColumnName("id_cc_didgroup")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.IdCcCountry)
                .IsRequired()
                .HasColumnName("id_cc_country")
                .HasColumnType("int(11)");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Reserved)
                .HasColumnName("reserved")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Iduser)
                .IsRequired()
                .HasColumnName("iduser")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Did)
                .IsRequired()
                .HasColumnName("did")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Startingdate)
                .IsRequired()
                .HasColumnName("startingdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Expirationdate)
                .IsRequired()
                .HasColumnName("expirationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.Secondusedreal)
                .HasColumnName("secondusedreal")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Billingtype)
                .HasColumnName("billingtype")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Fixrate)
                .IsRequired()
                .HasColumnName("fixrate")
                .HasColumnType("float");

            builder.Property(t => t.ConnectionCharge)
                .IsRequired()
                .HasColumnName("connection_charge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.SellingRate)
                .IsRequired()
                .HasColumnName("selling_rate")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegCarrierConnectCharge)
                .IsRequired()
                .HasColumnName("aleg_carrier_connect_charge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegCarrierCostMin)
                .IsRequired()
                .HasColumnName("aleg_carrier_cost_min")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegRetailConnectCharge)
                .IsRequired()
                .HasColumnName("aleg_retail_connect_charge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegRetailCostMin)
                .IsRequired()
                .HasColumnName("aleg_retail_cost_min")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegCarrierInitblock)
                .IsRequired()
                .HasColumnName("aleg_carrier_initblock")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegCarrierIncrement)
                .IsRequired()
                .HasColumnName("aleg_carrier_increment")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegRetailInitblock)
                .IsRequired()
                .HasColumnName("aleg_retail_initblock")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegRetailIncrement)
                .IsRequired()
                .HasColumnName("aleg_retail_increment")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegTimeinterval)
                .HasColumnName("aleg_timeinterval")
                .HasColumnType("text");

            builder.Property(t => t.AlegCarrierConnectChargeOffp)
                .IsRequired()
                .HasColumnName("aleg_carrier_connect_charge_offp")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegCarrierCostMinOffp)
                .IsRequired()
                .HasColumnName("aleg_carrier_cost_min_offp")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegRetailConnectChargeOffp)
                .IsRequired()
                .HasColumnName("aleg_retail_connect_charge_offp")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegRetailCostMinOffp)
                .IsRequired()
                .HasColumnName("aleg_retail_cost_min_offp")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AlegCarrierInitblockOffp)
                .IsRequired()
                .HasColumnName("aleg_carrier_initblock_offp")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegCarrierIncrementOffp)
                .IsRequired()
                .HasColumnName("aleg_carrier_increment_offp")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegRetailInitblockOffp)
                .IsRequired()
                .HasColumnName("aleg_retail_initblock_offp")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlegRetailIncrementOffp)
                .IsRequired()
                .HasColumnName("aleg_retail_increment_offp")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaxConcurrent)
                .IsRequired()
                .HasColumnName("max_concurrent")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'10'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_did";

        public const string ColumnId = "id";
        public const string ColumnIdCcDidgroup = "id_cc_didgroup";
        public const string ColumnIdCcCountry = "id_cc_country";
        public const string ColumnActivated = "activated";
        public const string ColumnReserved = "reserved";
        public const string ColumnIduser = "iduser";
        public const string ColumnDid = "did";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnStartingdate = "startingdate";
        public const string ColumnExpirationdate = "expirationdate";
        public const string ColumnDescription = "description";
        public const string ColumnSecondusedreal = "secondusedreal";
        public const string ColumnBillingtype = "billingtype";
        public const string ColumnFixrate = "fixrate";
        public const string ColumnConnectionCharge = "connection_charge";
        public const string ColumnSellingRate = "selling_rate";
        public const string ColumnAlegCarrierConnectCharge = "aleg_carrier_connect_charge";
        public const string ColumnAlegCarrierCostMin = "aleg_carrier_cost_min";
        public const string ColumnAlegRetailConnectCharge = "aleg_retail_connect_charge";
        public const string ColumnAlegRetailCostMin = "aleg_retail_cost_min";
        public const string ColumnAlegCarrierInitblock = "aleg_carrier_initblock";
        public const string ColumnAlegCarrierIncrement = "aleg_carrier_increment";
        public const string ColumnAlegRetailInitblock = "aleg_retail_initblock";
        public const string ColumnAlegRetailIncrement = "aleg_retail_increment";
        public const string ColumnAlegTimeinterval = "aleg_timeinterval";
        public const string ColumnAlegCarrierConnectChargeOffp = "aleg_carrier_connect_charge_offp";
        public const string ColumnAlegCarrierCostMinOffp = "aleg_carrier_cost_min_offp";
        public const string ColumnAlegRetailConnectChargeOffp = "aleg_retail_connect_charge_offp";
        public const string ColumnAlegRetailCostMinOffp = "aleg_retail_cost_min_offp";
        public const string ColumnAlegCarrierInitblockOffp = "aleg_carrier_initblock_offp";
        public const string ColumnAlegCarrierIncrementOffp = "aleg_carrier_increment_offp";
        public const string ColumnAlegRetailInitblockOffp = "aleg_retail_initblock_offp";
        public const string ColumnAlegRetailIncrementOffp = "aleg_retail_increment_offp";
        public const string ColumnMaxConcurrent = "max_concurrent";
        #endregion
    }
}
