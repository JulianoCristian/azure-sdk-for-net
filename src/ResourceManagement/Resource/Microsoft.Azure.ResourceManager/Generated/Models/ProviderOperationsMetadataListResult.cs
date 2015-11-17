// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Provider operations metadata list
    /// </summary>
    public partial class ProviderOperationsMetadataListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProviderOperationsMetadataListResult class.
        /// </summary>
        public ProviderOperationsMetadataListResult() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ProviderOperationsMetadataListResult class.
        /// </summary>
        public ProviderOperationsMetadataListResult(IList<ProviderOperationsMetadata> value = default(IList<ProviderOperationsMetadata>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of providers.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ProviderOperationsMetadata> Value { get; set; }

    }
}