// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ConnectedEnvironmentStorageResource" /> and their operations.
    /// Each <see cref="ConnectedEnvironmentStorageResource" /> in the collection will belong to the same instance of <see cref="ConnectedEnvironmentResource" />.
    /// To get a <see cref="ConnectedEnvironmentStorageCollection" /> instance call the GetConnectedEnvironmentStorages method from an instance of <see cref="ConnectedEnvironmentResource" />.
    /// </summary>
    public partial class ConnectedEnvironmentStorageCollection : ArmCollection, IEnumerable<ConnectedEnvironmentStorageResource>, IAsyncEnumerable<ConnectedEnvironmentStorageResource>
    {
        private readonly ClientDiagnostics _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics;
        private readonly ConnectedEnvironmentsStoragesRestOperations _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConnectedEnvironmentStorageCollection"/> class for mocking. </summary>
        protected ConnectedEnvironmentStorageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConnectedEnvironmentStorageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConnectedEnvironmentStorageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ConnectedEnvironmentStorageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConnectedEnvironmentStorageResource.ResourceType, out string connectedEnvironmentStorageConnectedEnvironmentsStoragesApiVersion);
            _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient = new ConnectedEnvironmentsStoragesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, connectedEnvironmentStorageConnectedEnvironmentsStoragesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ConnectedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ConnectedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update storage for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConnectedEnvironmentStorageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageName, ConnectedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ConnectedEnvironmentStorageResource>(Response.FromValue(new ConnectedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update storage for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="data"> Configuration details of storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConnectedEnvironmentStorageResource> CreateOrUpdate(WaitUntil waitUntil, string storageName, ConnectedEnvironmentStorageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ConnectedEnvironmentStorageResource>(Response.FromValue(new ConnectedEnvironmentStorageResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get storage for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<ConnectedEnvironmentStorageResource>> GetAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = await _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get storage for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<ConnectedEnvironmentStorageResource> Get(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.Get");
            scope.Start();
            try
            {
                var response = _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectedEnvironmentStorageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all storages for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages
        /// Operation Id: ConnectedEnvironmentsStorages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConnectedEnvironmentStorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConnectedEnvironmentStorageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ConnectedEnvironmentStorageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedEnvironmentStorageResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all storages for a connectedEnvironment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages
        /// Operation Id: ConnectedEnvironmentsStorages_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConnectedEnvironmentStorageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConnectedEnvironmentStorageResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ConnectedEnvironmentStorageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedEnvironmentStorageResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/storages/{storageName}
        /// Operation Id: ConnectedEnvironmentsStorages_Get
        /// </summary>
        /// <param name="storageName"> Name of the storage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageName, nameof(storageName));

            using var scope = _connectedEnvironmentStorageConnectedEnvironmentsStoragesClientDiagnostics.CreateScope("ConnectedEnvironmentStorageCollection.Exists");
            scope.Start();
            try
            {
                var response = _connectedEnvironmentStorageConnectedEnvironmentsStoragesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConnectedEnvironmentStorageResource> IEnumerable<ConnectedEnvironmentStorageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConnectedEnvironmentStorageResource> IAsyncEnumerable<ConnectedEnvironmentStorageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
