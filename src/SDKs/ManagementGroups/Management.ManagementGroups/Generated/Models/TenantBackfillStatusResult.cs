// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The tenant backfill status
    /// </summary>
    public partial class TenantBackfillStatusResult
    {
        /// <summary>
        /// Initializes a new instance of the TenantBackfillStatusResult class.
        /// </summary>
        public TenantBackfillStatusResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantBackfillStatusResult class.
        /// </summary>
        /// <param name="tenantId">The AAD Tenant ID associated with the
        /// management group. For example,
        /// 00000000-0000-0000-0000-000000000000</param>
        /// <param name="status">The status of the Tenant Backfill. Possible
        /// values include: 'NotStarted', 'NotStartedButGroupsExist',
        /// 'Started', 'Failed', 'Cancelled', 'Completed'</param>
        public TenantBackfillStatusResult(string tenantId = default(string), Status? status = default(Status?))
        {
            TenantId = tenantId;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the AAD Tenant ID associated with the management group. For
        /// example, 00000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets the status of the Tenant Backfill. Possible values include:
        /// 'NotStarted', 'NotStartedButGroupsExist', 'Started', 'Failed',
        /// 'Cancelled', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; private set; }

    }
}
