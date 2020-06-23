// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagement : Entity
    {
    
		///<summary>
		/// The DeviceManagement constructor
		///</summary>
        public DeviceManagement()
        {
            this.ODataType = "microsoft.graph.deviceManagement";
        }
	
        /// <summary>
        /// Gets or sets settings.
        /// Account level settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets intune account id.
        /// Intune Account Id for given tenant
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneAccountId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? IntuneAccountId { get; set; }
    
        /// <summary>
        /// Gets or sets intune brand.
        /// intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneBrand", Required = Newtonsoft.Json.Required.Default)]
        public IntuneBrand IntuneBrand { get; set; }
    
        /// <summary>
        /// Gets or sets subscription state.
        /// Tenant mobile device management subscription state. The possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions.
        /// The terms and conditions associated with device management of the company.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTermsAndConditionsCollectionPage TermsAndConditions { get; set; }
    
        /// <summary>
        /// Gets or sets device configurations.
        /// The device configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationsCollectionPage DeviceConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policies.
        /// The device compliance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePoliciesCollectionPage DeviceCompliancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets software update status summary.
        /// The software update status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdateStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy device state summary.
        /// The device compliance state summary for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyDeviceStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy setting state summaries.
        /// The summary states of compliance policy settings for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicySettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePolicySettingStateSummariesCollectionPage DeviceCompliancePolicySettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration device state summaries.
        /// The device configuration device state summary for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationDeviceStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets ios update statuses.
        /// The IOS software update installation statuses for this account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosUpdateStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIosUpdateStatusesCollectionPage IosUpdateStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets device categories.
        /// The list of device categories with the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCategoriesCollectionPage DeviceCategories { get; set; }
    
        /// <summary>
        /// Gets or sets exchange connectors.
        /// The list of Exchange Connectors configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementExchangeConnectorsCollectionPage ExchangeConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment configurations.
        /// The list of device enrollment configurations
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceEnrollmentConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceEnrollmentConfigurationsCollectionPage DeviceEnrollmentConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access settings.
        /// The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessSettings", Required = Newtonsoft.Json.Required.Default)]
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
    
        /// <summary>
        /// Gets or sets mobile threat defense connectors.
        /// The list of Mobile threat Defense connectors configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileThreatDefenseConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementMobileThreatDefenseConnectorsCollectionPage MobileThreatDefenseConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device management partners.
        /// The list of Device Management Partners configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceManagementPartnersCollectionPage DeviceManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets compliance management partners.
        /// The list of Compliance Management Partners configured by the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementComplianceManagementPartnersCollectionPage ComplianceManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets apple push notification certificate.
        /// Apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePushNotificationCertificate", Required = Newtonsoft.Json.Required.Default)]
        public ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets managed device overview.
        /// Device overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceOverview", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceOverview ManagedDeviceOverview { get; set; }
    
        /// <summary>
        /// Gets or sets detected apps.
        /// The list of detected apps associated with a device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectedApps", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDetectedAppsCollectionPage DetectedApps { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The list of managed devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagedDevicesCollectionPage ManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets notification message templates.
        /// The Notification Message Templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationMessageTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementNotificationMessageTemplatesCollectionPage NotificationMessageTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// The Role Definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// The Role Assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets resource operations.
        /// The Resource Operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceOperations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementResourceOperationsCollectionPage ResourceOperations { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance partners.
        /// The remote assist partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAssistancePartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRemoteAssistancePartnersCollectionPage RemoteAssistancePartners { get; set; }
    
        /// <summary>
        /// Gets or sets telecom expense management partners.
        /// The telecom expense management partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "telecomExpenseManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionPage TelecomExpenseManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets troubleshooting events.
        /// The list of troubleshooting events for the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "troubleshootingEvents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTroubleshootingEventsCollectionPage TroubleshootingEvents { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection app learning summaries.
        /// The windows information protection app learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionAppLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionPage WindowsInformationProtectionAppLearningSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection network learning summaries.
        /// The windows information protection network learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionNetworkLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionPage WindowsInformationProtectionNetworkLearningSummaries { get; set; }
    
    }
}

