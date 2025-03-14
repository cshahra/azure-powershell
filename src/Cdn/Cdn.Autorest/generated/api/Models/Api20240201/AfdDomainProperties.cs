// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the domain to create.</summary>
    public partial class AfdDomainProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParameters __afdDomainUpdatePropertiesParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.AfdDomainUpdatePropertiesParameters();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStateProperties __afdStateProperties = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.AfdStateProperties();

        /// <summary>
        /// Resource reference to the Azure resource where custom domain ownership was prevalidated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IResourceReference AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId = value ?? null /* model class */; }

        /// <summary>Resource reference to the Azure DNS zone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IResourceReference AzureDnsZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AzureDnsZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AzureDnsZone = value ?? null /* model class */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string AzureDnsZoneId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AzureDnsZoneId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).AzureDnsZoneId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; }

        /// <summary>Backing field for <see cref="DomainValidationState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState? _domainValidationState;

        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState? DomainValidationState { get => this._domainValidationState; }

        /// <summary>Backing field for <see cref="ExtendedProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesExtendedProperties _extendedProperty;

        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get => (this._extendedProperty = this._extendedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.AfdDomainPropertiesExtendedProperties()); set => this._extendedProperty = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>The host name of the domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Internal Acessors for DomainValidationState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesInternal.DomainValidationState { get => this._domainValidationState; set { {_domainValidationState = value;} } }

        /// <summary>Internal Acessors for ValidationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesInternal.ValidationProperty { get => (this._validationProperty = this._validationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.DomainValidationProperties()); set { {_validationProperty = value;} } }

        /// <summary>Internal Acessors for ValidationPropertyExpirationDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesInternal.ValidationPropertyExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ExpirationDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ExpirationDate = value; }

        /// <summary>Internal Acessors for ValidationPropertyValidationToken</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesInternal.ValidationPropertyValidationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ValidationToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ValidationToken = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).ProfileName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).ProfileName = value; }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).DeploymentStatus = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string PreValidatedCustomDomainResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).PreValidatedCustomDomainResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).PreValidatedCustomDomainResourceId = value ?? null; }

        /// <summary>The name of the profile which holds the domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).ProfileName; }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal)__afdStateProperties).ProvisioningState; }

        /// <summary>
        /// The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own
        /// certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainHttpsParameters TlsSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).TlsSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal)__afdDomainUpdatePropertiesParameters).TlsSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="ValidationProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationProperties _validationProperty;

        /// <summary>Values the customer needs to validate domain ownership</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationProperties ValidationProperty { get => (this._validationProperty = this._validationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.DomainValidationProperties()); }

        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ValidationPropertyExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ExpirationDate; }

        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ValidationPropertyValidationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationPropertiesInternal)ValidationProperty).ValidationToken; }

        /// <summary>Creates an new <see cref="AfdDomainProperties" /> instance.</summary>
        public AfdDomainProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__afdDomainUpdatePropertiesParameters), __afdDomainUpdatePropertiesParameters);
            await eventListener.AssertObjectIsValid(nameof(__afdDomainUpdatePropertiesParameters), __afdDomainUpdatePropertiesParameters);
            await eventListener.AssertNotNull(nameof(__afdStateProperties), __afdStateProperties);
            await eventListener.AssertObjectIsValid(nameof(__afdStateProperties), __afdStateProperties);
        }
    }
    /// The JSON object that contains the properties of the domain to create.
    public partial interface IAfdDomainProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStateProperties
    {
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.",
        SerializedName = @"domainValidationState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState? DomainValidationState { get;  }
        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key-Value pair representing migration properties for domains.",
        SerializedName = @"extendedProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesExtendedProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The host name of the domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The host name of the domain. Must be a domain name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date time that the token expires",
        SerializedName = @"expirationDate",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationPropertyExpirationDate { get;  }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Challenge used for DNS TXT record or file based validation",
        SerializedName = @"validationToken",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationPropertyValidationToken { get;  }

    }
    /// The JSON object that contains the properties of the domain to create.
    internal partial interface IAfdDomainPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainUpdatePropertiesParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdStatePropertiesInternal
    {
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState? DomainValidationState { get; set; }
        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The host name of the domain. Must be a domain name.</summary>
        string HostName { get; set; }
        /// <summary>Values the customer needs to validate domain ownership</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IDomainValidationProperties ValidationProperty { get; set; }
        /// <summary>The date time that the token expires</summary>
        string ValidationPropertyExpirationDate { get; set; }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        string ValidationPropertyValidationToken { get; set; }

    }
}