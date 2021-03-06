// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ImagesOperations.
    /// </summary>
    public static partial class ImagesOperationsExtensions
    {
            /// <summary>
            /// Gets entity type (profile or interaction) image upload URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the GetUploadUrlForEntityType operation.
            /// </param>
            public static ImageDefinition GetUploadUrlForEntityType(this IImagesOperations operations, string resourceGroupName, string hubName, GetImageUploadUrlInput parameters)
            {
                return operations.GetUploadUrlForEntityTypeAsync(resourceGroupName, hubName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets entity type (profile or interaction) image upload URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the GetUploadUrlForEntityType operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImageDefinition> GetUploadUrlForEntityTypeAsync(this IImagesOperations operations, string resourceGroupName, string hubName, GetImageUploadUrlInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUploadUrlForEntityTypeWithHttpMessagesAsync(resourceGroupName, hubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets data image upload URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the GetUploadUrlForData operation.
            /// </param>
            public static ImageDefinition GetUploadUrlForData(this IImagesOperations operations, string resourceGroupName, string hubName, GetImageUploadUrlInput parameters)
            {
                return operations.GetUploadUrlForDataAsync(resourceGroupName, hubName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets data image upload URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the GetUploadUrlForData operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImageDefinition> GetUploadUrlForDataAsync(this IImagesOperations operations, string resourceGroupName, string hubName, GetImageUploadUrlInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUploadUrlForDataWithHttpMessagesAsync(resourceGroupName, hubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

