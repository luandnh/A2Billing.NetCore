using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcRatecardMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcRatecard>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcRatecard> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_ratecard");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Idtariffplan)
                .IsRequired()
                .HasColumnName("idtariffplan")
                .HasColumnType("int(11)");

            builder.Property(t => t.Dialprefix)
                .IsRequired()
                .HasColumnName("dialprefix")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Buyrate)
                .IsRequired()
                .HasColumnName("buyrate")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Buyrateinitblock)
                .IsRequired()
                .HasColumnName("buyrateinitblock")
                .HasColumnType("int(11)");

            builder.Property(t => t.Buyrateincrement)
                .IsRequired()
                .HasColumnName("buyrateincrement")
                .HasColumnType("int(11)");

            builder.Property(t => t.Rateinitial)
                .IsRequired()
                .HasColumnName("rateinitial")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Initblock)
                .IsRequired()
                .HasColumnName("initblock")
                .HasColumnType("int(11)");

            builder.Property(t => t.Billingblock)
                .IsRequired()
                .HasColumnName("billingblock")
                .HasColumnType("int(11)");

            builder.Property(t => t.Connectcharge)
                .IsRequired()
                .HasColumnName("connectcharge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Disconnectcharge)
                .IsRequired()
                .HasColumnName("disconnectcharge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Stepchargea)
                .IsRequired()
                .HasColumnName("stepchargea")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Chargea)
                .IsRequired()
                .HasColumnName("chargea")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Timechargea)
                .IsRequired()
                .HasColumnName("timechargea")
                .HasColumnType("int(11)");

            builder.Property(t => t.Billingblocka)
                .IsRequired()
                .HasColumnName("billingblocka")
                .HasColumnType("int(11)");

            builder.Property(t => t.Stepchargeb)
                .IsRequired()
                .HasColumnName("stepchargeb")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Chargeb)
                .IsRequired()
                .HasColumnName("chargeb")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Timechargeb)
                .IsRequired()
                .HasColumnName("timechargeb")
                .HasColumnType("int(11)");

            builder.Property(t => t.Billingblockb)
                .IsRequired()
                .HasColumnName("billingblockb")
                .HasColumnType("int(11)");

            builder.Property(t => t.Stepchargec)
                .IsRequired()
                .HasColumnName("stepchargec")
                .HasColumnType("float");

            builder.Property(t => t.Chargec)
                .IsRequired()
                .HasColumnName("chargec")
                .HasColumnType("float");

            builder.Property(t => t.Timechargec)
                .IsRequired()
                .HasColumnName("timechargec")
                .HasColumnType("int(11)");

            builder.Property(t => t.Billingblockc)
                .IsRequired()
                .HasColumnName("billingblockc")
                .HasColumnType("int(11)");

            builder.Property(t => t.Startdate)
                .IsRequired()
                .HasColumnName("startdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Stopdate)
                .IsRequired()
                .HasColumnName("stopdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Starttime)
                .HasColumnName("starttime")
                .HasColumnType("smallint(5) unsigned")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Endtime)
                .HasColumnName("endtime")
                .HasColumnType("smallint(5) unsigned")
                .HasDefaultValueSql("'10079'");

            builder.Property(t => t.IdTrunk)
                .HasColumnName("id_trunk")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.Musiconhold)
                .IsRequired()
                .HasColumnName("musiconhold")
                .HasColumnType("char(100)")
                .HasMaxLength(100);

            builder.Property(t => t.IdOutboundCidgroup)
                .HasColumnName("id_outbound_cidgroup")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.RoundingCalltime)
                .IsRequired()
                .HasColumnName("rounding_calltime")
                .HasColumnType("int(11)");

            builder.Property(t => t.RoundingThreshold)
                .IsRequired()
                .HasColumnName("rounding_threshold")
                .HasColumnType("int(11)");

            builder.Property(t => t.AdditionalBlockCharge)
                .IsRequired()
                .HasColumnName("additional_block_charge")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AdditionalBlockChargeTime)
                .IsRequired()
                .HasColumnName("additional_block_charge_time")
                .HasColumnType("int(11)");

            builder.Property(t => t.Tag)
                .HasColumnName("tag")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DisconnectchargeAfter)
                .IsRequired()
                .HasColumnName("disconnectcharge_after")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsMerged)
                .HasColumnName("is_merged")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.AdditionalGrace)
                .IsRequired()
                .HasColumnName("additional_grace")
                .HasColumnType("int(11)");

            builder.Property(t => t.MinimalCost)
                .IsRequired()
                .HasColumnName("minimal_cost")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.AnnounceTimeCorrection)
                .IsRequired()
                .HasColumnName("announce_time_correction")
                .HasColumnType("decimal(5,3)")
                .HasDefaultValueSql("'1.000'");

            builder.Property(t => t.Destination)
                .IsRequired()
                .HasColumnName("destination")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_ratecard";

        public const string ColumnId = "id";
        public const string ColumnIdtariffplan = "idtariffplan";
        public const string ColumnDialprefix = "dialprefix";
        public const string ColumnBuyrate = "buyrate";
        public const string ColumnBuyrateinitblock = "buyrateinitblock";
        public const string ColumnBuyrateincrement = "buyrateincrement";
        public const string ColumnRateinitial = "rateinitial";
        public const string ColumnInitblock = "initblock";
        public const string ColumnBillingblock = "billingblock";
        public const string ColumnConnectcharge = "connectcharge";
        public const string ColumnDisconnectcharge = "disconnectcharge";
        public const string ColumnStepchargea = "stepchargea";
        public const string ColumnChargea = "chargea";
        public const string ColumnTimechargea = "timechargea";
        public const string ColumnBillingblocka = "billingblocka";
        public const string ColumnStepchargeb = "stepchargeb";
        public const string ColumnChargeb = "chargeb";
        public const string ColumnTimechargeb = "timechargeb";
        public const string ColumnBillingblockb = "billingblockb";
        public const string ColumnStepchargec = "stepchargec";
        public const string ColumnChargec = "chargec";
        public const string ColumnTimechargec = "timechargec";
        public const string ColumnBillingblockc = "billingblockc";
        public const string ColumnStartdate = "startdate";
        public const string ColumnStopdate = "stopdate";
        public const string ColumnStarttime = "starttime";
        public const string ColumnEndtime = "endtime";
        public const string ColumnIdTrunk = "id_trunk";
        public const string ColumnMusiconhold = "musiconhold";
        public const string ColumnIdOutboundCidgroup = "id_outbound_cidgroup";
        public const string ColumnRoundingCalltime = "rounding_calltime";
        public const string ColumnRoundingThreshold = "rounding_threshold";
        public const string ColumnAdditionalBlockCharge = "additional_block_charge";
        public const string ColumnAdditionalBlockChargeTime = "additional_block_charge_time";
        public const string ColumnTag = "tag";
        public const string ColumnDisconnectchargeAfter = "disconnectcharge_after";
        public const string ColumnIsMerged = "is_merged";
        public const string ColumnAdditionalGrace = "additional_grace";
        public const string ColumnMinimalCost = "minimal_cost";
        public const string ColumnAnnounceTimeCorrection = "announce_time_correction";
        public const string ColumnDestination = "destination";
        #endregion
    }
}
