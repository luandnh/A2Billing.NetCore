using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NesopsService.Data
{
    public partial class Mya2billingContext : DbContext
    {
        public Mya2billingContext(DbContextOptions<Mya2billingContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<NesopsService.Data.Entities.CcAgentCommission> CcAgentCommissions { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAgent> CcAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAgentSignup> CcAgentSignups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAgentTariffgroup> CcAgentTariffgroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAlarmReport> CcAlarmReports { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAlarm> CcAlarms { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcAutorefillReport> CcAutorefillReports { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcBackup> CcBackups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcBillingCustomer> CcBillingCustomers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCallArchive> CcCallArchives { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCallbackSpool> CcCallbackSpools { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCallerid> CcCallerids { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCallplanLcr> CcCallplanLcrs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCall> CcCalls { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCampaignconfCardgroup> CcCampaignconfCardgroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCampaignConfig> CcCampaignConfigs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCampaignPhonebook> CcCampaignPhonebooks { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCampaignPhonestatus> CcCampaignPhonestatuses { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCampaign> CcCampaigns { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardArchive> CcCardArchives { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardGroup> CcCardGroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardgroupService> CcCardgroupServices { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardHistory> CcCardHistories { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardPackageOffer> CcCardPackageOffers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCard> CcCards { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardSeria> CcCardSeria { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCardSubscription> CcCardSubscriptions { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCharge> CcCharges { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcConfigGroup> CcConfigGroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcConfig> CcConfigs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcConfiguration> CcConfigurations { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcContact> CcContacts { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCountry> CcCountries { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcCurrencies> CcCurrencies { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcDidDestination> CcDidDestinations { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcDidgroup> CcDidgroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcDid> CcDids { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcDidUse> CcDidUses { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcEpaymentLogAgent> CcEpaymentLogAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcEpaymentLog> CcEpaymentLogs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcIaxBuddies> CcIaxBuddies { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcInvoiceConf> CcInvoiceConfs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcInvoiceItem> CcInvoiceItems { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcInvoicePayment> CcInvoicePayments { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcInvoice> CcInvoices { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcIso639> CcIso639s { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcLogpaymentAgent> CcLogpaymentAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcLogpayment> CcLogpayments { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcLogrefillAgent> CcLogrefillAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcLogrefill> CcLogrefills { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcMessageAgent> CcMessageAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcMonitor> CcMonitors { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcNotificationAdmin> CcNotificationAdmins { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcNotification> CcNotifications { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcOutboundCidGroup> CcOutboundCidGroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcOutboundCidList> CcOutboundCidLists { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPackageGroup> CcPackageGroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPackageOffer> CcPackageOffers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPackageRate> CcPackageRates { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPackgroupPackage> CcPackgroupPackages { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPaymentMethods> CcPaymentMethods { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPayments> CcPayments { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPaymentsAgent> CcPaymentsAgents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPaymentsStatus> CcPaymentsStatuses { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPaypal> CcPaypals { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPhonebook> CcPhonebooks { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPhonenumber> CcPhonenumbers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcPrefix> CcPrefixes { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcProvider> CcProviders { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcRatecard> CcRatecards { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcReceiptItem> CcReceiptItems { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcReceipt> CcReceipts { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcRemittanceRequest> CcRemittanceRequests { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcRestrictedPhonenumber> CcRestrictedPhonenumbers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcServerGroup> CcServerGroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcServerManager> CcServerManagers { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcServiceReport> CcServiceReports { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcService> CcServices { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSipBuddies> CcSipBuddies { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSipBuddiesEmpty> CcSipBuddiesEmpties { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSpeeddial> CcSpeeddials { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcStatusLog> CcStatusLogs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSubscriptionService> CcSubscriptionServices { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSubscriptionSignup> CcSubscriptionSignups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSupportComponent> CcSupportComponents { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSupport> CcSupports { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcSystemLog> CcSystemLogs { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTariffgroupPlan> CcTariffgroupPlans { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTariffgroup> CcTariffgroups { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTariffplan> CcTariffplans { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTemplatemail> CcTemplatemails { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTicketComment> CcTicketComments { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTicket> CcTickets { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTimezone> CcTimezones { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcTrunk> CcTrunks { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcUiAuthen> CcUiAuthens { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcVersion> CcVersions { get; set; }

        public virtual DbSet<NesopsService.Data.Entities.CcVoucher> CcVouchers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAgentCommissionMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAgentSignupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAgentTariffgroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAlarmMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAlarmReportMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcAutorefillReportMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcBackupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcBillingCustomerMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCallArchiveMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCallbackSpoolMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCalleridMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCallMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCallplanLcrMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCampaignconfCardgroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCampaignConfigMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCampaignMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCampaignPhonebookMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCampaignPhonestatusMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardArchiveMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardGroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardgroupServiceMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardHistoryMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardPackageOfferMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardSeriaMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCardSubscriptionMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcChargeMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcConfigGroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcConfigMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcConfigurationMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcContactMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCountryMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcCurrenciesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcDidDestinationMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcDidgroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcDidMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcDidUseMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcEpaymentLogAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcEpaymentLogMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcIaxBuddiesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcInvoiceConfMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcInvoiceItemMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcInvoiceMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcInvoicePaymentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcIso639Map());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcLogpaymentAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcLogpaymentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcLogrefillAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcLogrefillMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcMessageAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcMonitorMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcNotificationAdminMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcNotificationMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcOutboundCidGroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcOutboundCidListMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPackageGroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPackageOfferMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPackageRateMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPackgroupPackageMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPaymentMethodsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPaymentsAgentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPaymentsMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPaymentsStatusMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPaypalMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPhonebookMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPhonenumberMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcPrefixMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcProviderMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcRatecardMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcReceiptItemMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcReceiptMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcRemittanceRequestMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcRestrictedPhonenumberMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcServerGroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcServerManagerMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcServiceMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcServiceReportMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSipBuddiesEmptyMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSipBuddiesMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSpeeddialMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcStatusLogMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSubscriptionServiceMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSubscriptionSignupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSupportComponentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSupportMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcSystemLogMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTariffgroupMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTariffgroupPlanMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTariffplanMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTemplatemailMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTicketCommentMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTicketMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTimezoneMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcTrunkMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcUiAuthenMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcVersionMap());
            modelBuilder.ApplyConfiguration(new NesopsService.Data.Mapping.CcVoucherMap());
            #endregion
        }
    }
}
