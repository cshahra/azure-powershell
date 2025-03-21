// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Action that need to performed.</summary>
    public partial class NetworkTapRuleAction
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRuleAction.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRuleAction.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRuleAction FromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject json ? new NetworkTapRuleAction(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject into a new instance of <see cref="NetworkTapRuleAction" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal NetworkTapRuleAction(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_truncate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString>("truncate"), out var __jsonTruncate) ? (string)__jsonTruncate : (string)_truncate;}
            {_isTimestampEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString>("isTimestampEnabled"), out var __jsonIsTimestampEnabled) ? (string)__jsonIsTimestampEnabled : (string)_isTimestampEnabled;}
            {_destinationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString>("destinationId"), out var __jsonDestinationId) ? (string)__jsonDestinationId : (string)_destinationId;}
            {_matchConfigurationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString>("matchConfigurationName"), out var __jsonMatchConfigurationName) ? (string)__jsonMatchConfigurationName : (string)_matchConfigurationName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="NetworkTapRuleAction" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NetworkTapRuleAction" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._truncate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString(this._truncate.ToString()) : null, "truncate" ,container.Add );
            AddIf( null != (((object)this._isTimestampEnabled)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString(this._isTimestampEnabled.ToString()) : null, "isTimestampEnabled" ,container.Add );
            AddIf( null != (((object)this._destinationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString(this._destinationId.ToString()) : null, "destinationId" ,container.Add );
            AddIf( null != (((object)this._matchConfigurationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonString(this._matchConfigurationName.ToString()) : null, "matchConfigurationName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}