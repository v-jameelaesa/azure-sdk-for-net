// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationRuntimeNodesOperations.
    /// </summary>
    public static partial class IntegrationRuntimeNodesOperationsExtensions
    {
            /// <summary>
            /// Get integration runtime node
            /// </summary>
            /// <remarks>
            /// Get an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            public static SelfHostedIntegrationRuntimeNode Get(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get integration runtime node
            /// </summary>
            /// <remarks>
            /// Get an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SelfHostedIntegrationRuntimeNode> GetAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create integration runtime node
            /// </summary>
            /// <remarks>
            /// Create an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            /// <param name='updateIntegrationRuntimeNodeRequest'>
            /// The parameters for updating an integration runtime node.
            /// </param>
            public static SelfHostedIntegrationRuntimeNode Update(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeRequest updateIntegrationRuntimeNodeRequest)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName, updateIntegrationRuntimeNodeRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create integration runtime node
            /// </summary>
            /// <remarks>
            /// Create an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            /// <param name='updateIntegrationRuntimeNodeRequest'>
            /// The parameters for updating an integration runtime node.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SelfHostedIntegrationRuntimeNode> UpdateAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, UpdateIntegrationRuntimeNodeRequest updateIntegrationRuntimeNodeRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName, updateIntegrationRuntimeNodeRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete integration runtime node
            /// </summary>
            /// <remarks>
            /// Delete an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            public static void Delete(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete integration runtime node
            /// </summary>
            /// <remarks>
            /// Delete an integration runtime node
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='nodeName'>
            /// Integration runtime node name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationRuntimeNodesOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, nodeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
