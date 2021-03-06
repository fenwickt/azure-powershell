// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that define a direct connection.
    /// </summary>
    public partial class PSDirectConnection
    {
        /// <summary>
        /// Initializes a new instance of the PSDirectConnection class.
        /// </summary>
        public PSDirectConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSDirectConnection class.
        /// </summary>
        /// <param name="bandwidthInMbps">The bandwidth of the
        /// connection.</param>
        /// <param name="provisionedBandwidthInMbps">The bandwidth that is
        /// actually provisioned.</param>
        /// <param name="sessionAddressProvider">The field indicating if
        /// Microsoft provides session ip addresses. Possible values include:
        /// 'Microsoft', 'Peer'</param>
        /// <param name="useForPeeringService">The flag that indicates whether
        /// or not the connection is used for peering service.</param>
        /// <param name="microsoftTrackingId">The ID used within Microsoft's 
        /// peering provisioning system to track the connection.</param>
        /// <param name="peeringDBFacilityId">The PeeringDB.com ID of the
        /// facility at which the connection has to be set up.</param>
        /// <param name="connectionState">The state of the connection. Possible
        /// values include: 'None', 'PendingApproval', 'Approved',
        /// 'ProvisioningStarted', 'ProvisioningFailed',
        /// 'ProvisioningCompleted', 'Validating', 'Active'</param>
        /// <param name="bgpSession">The BGP session associated with the
        /// connection.</param>
        /// <param name="connectionIdentifier">The unique identifier (GUID) for
        /// the connection.</param>
        /// <param name="errorMessage">The error message related to the
        /// connection state, if any.</param>
        public PSDirectConnection(int? bandwidthInMbps = default(int?), int? provisionedBandwidthInMbps = default(int?), string sessionAddressProvider = default(string), bool? useForPeeringService = default(bool?), string microsoftTrackingId = default(string), int? peeringDBFacilityId = default(int?), string connectionState = default(string), PSBgpSession bgpSession = default(PSBgpSession), string connectionIdentifier = default(string), string errorMessage = default(string))
        {
            BandwidthInMbps = bandwidthInMbps;
            ProvisionedBandwidthInMbps = provisionedBandwidthInMbps;
            SessionAddressProvider = sessionAddressProvider;
            UseForPeeringService = useForPeeringService;
            MicrosoftTrackingId = microsoftTrackingId;
            PeeringDBFacilityId = peeringDBFacilityId;
            ConnectionState = connectionState;
            BgpSession = bgpSession;
            ConnectionIdentifier = connectionIdentifier;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the bandwidth of the connection.
        /// </summary>
        [JsonProperty(PropertyName = "bandwidthInMbps")]
        public int? BandwidthInMbps { get; set; }

        /// <summary>
        /// Gets the bandwidth that is actually provisioned.
        /// </summary>
        [JsonProperty(PropertyName = "provisionedBandwidthInMbps")]
        public int? ProvisionedBandwidthInMbps { get; private set; }

        /// <summary>
        /// Gets or sets the field indicating if Microsoft provides session ip
        /// addresses. Possible values include: 'Microsoft', 'Peer'
        /// </summary>
        [JsonProperty(PropertyName = "sessionAddressProvider")]
        public string SessionAddressProvider { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether or not the connection
        /// is used for peering service.
        /// </summary>
        [JsonProperty(PropertyName = "useForPeeringService")]
        public bool? UseForPeeringService { get; set; }

        /// <summary>
        /// Gets or sets the ID used within Microsoft's peering provisioning system to track the connection
        /// is used for peering service.
        /// </summary>
        [JsonProperty(PropertyName = "MicrosoftTrackingId")]
        public string MicrosoftTrackingId { get; private set; }

        /// <summary>
        /// Gets or sets the PeeringDB.com ID of the facility at which the
        /// connection has to be set up.
        /// </summary>
        [JsonProperty(PropertyName = "peeringDBFacilityId")]
        public int? PeeringDBFacilityId { get; set; }

        /// <summary>
        /// Gets the state of the connection. Possible values include: 'None',
        /// 'PendingApproval', 'Approved', 'ProvisioningStarted',
        /// 'ProvisioningFailed', 'ProvisioningCompleted', 'Validating',
        /// 'Active'
        /// </summary>
        [JsonProperty(PropertyName = "connectionState")]
        public string ConnectionState { get; private set; }

        /// <summary>
        /// Gets or sets the BGP session associated with the connection.
        /// </summary>
        [JsonProperty(PropertyName = "bgpSession")]
        public PSBgpSession BgpSession { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (GUID) for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "connectionIdentifier")]
        public string ConnectionIdentifier { get; set; }

        /// <summary>
        /// Gets the error message related to the connection state, if any.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; private set; }

    }
}
