// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _apiManagementDeletedServiceDeletedServicesClientDiagnostics;
        private DeletedServicesRestOperations _apiManagementDeletedServiceDeletedServicesRestClient;
        private ClientDiagnostics _apiManagementServiceClientDiagnostics;
        private ApiManagementServiceRestOperations _apiManagementServiceRestClient;
        private ClientDiagnostics _apiManagementSkusClientDiagnostics;
        private ApiManagementSkusRestOperations _apiManagementSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ApiManagementDeletedServiceDeletedServicesClientDiagnostics => _apiManagementDeletedServiceDeletedServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementDeletedServiceResource.ResourceType.Namespace, Diagnostics);
        private DeletedServicesRestOperations ApiManagementDeletedServiceDeletedServicesRestClient => _apiManagementDeletedServiceDeletedServicesRestClient ??= new DeletedServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApiManagementDeletedServiceResource.ResourceType));
        private ClientDiagnostics ApiManagementServiceClientDiagnostics => _apiManagementServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementServiceResource.ResourceType.Namespace, Diagnostics);
        private ApiManagementServiceRestOperations ApiManagementServiceRestClient => _apiManagementServiceRestClient ??= new ApiManagementServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApiManagementServiceResource.ResourceType));
        private ClientDiagnostics ApiManagementSkusClientDiagnostics => _apiManagementSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ApiManagementSkusRestOperations ApiManagementSkusRestClient => _apiManagementSkusRestClient ??= new ApiManagementSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ApiManagementDeletedServiceResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ApiManagementDeletedServiceResources and their operations over a ApiManagementDeletedServiceResource. </returns>
        public virtual ApiManagementDeletedServiceCollection GetApiManagementDeletedServices()
        {
            return GetCachedClient(Client => new ApiManagementDeletedServiceCollection(Client, Id));
        }

        /// <summary>
        /// Lists all soft-deleted services available for undelete for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/deletedservices
        /// Operation Id: DeletedServices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementDeletedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementDeletedServiceResource> GetApiManagementDeletedServicesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementDeletedServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementDeletedServices");
                scope.Start();
                try
                {
                    var response = await ApiManagementDeletedServiceDeletedServicesRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementDeletedServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementDeletedServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementDeletedServices");
                scope.Start();
                try
                {
                    var response = await ApiManagementDeletedServiceDeletedServicesRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementDeletedServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all soft-deleted services available for undelete for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/deletedservices
        /// Operation Id: DeletedServices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementDeletedServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementDeletedServiceResource> GetApiManagementDeletedServices(CancellationToken cancellationToken = default)
        {
            Page<ApiManagementDeletedServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementDeletedServices");
                scope.Start();
                try
                {
                    var response = ApiManagementDeletedServiceDeletedServicesRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementDeletedServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementDeletedServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementDeletedServiceDeletedServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementDeletedServices");
                scope.Start();
                try
                {
                    var response = ApiManagementDeletedServiceDeletedServicesRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementDeletedServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all API Management services within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/service
        /// Operation Id: ApiManagementService_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementServiceResource> GetApiManagementServicesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServices");
                scope.Start();
                try
                {
                    var response = await ApiManagementServiceRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServices");
                scope.Start();
                try
                {
                    var response = await ApiManagementServiceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all API Management services within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/service
        /// Operation Id: ApiManagementService_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementServiceResource> GetApiManagementServices(CancellationToken cancellationToken = default)
        {
            Page<ApiManagementServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServices");
                scope.Start();
                try
                {
                    var response = ApiManagementServiceRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServices");
                scope.Start();
                try
                {
                    var response = ApiManagementServiceRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks availability and correctness of a name for an API Management service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/checkNameAvailability
        /// Operation Id: ApiManagementService_CheckNameAvailability
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementServiceNameAvailabilityResult>> CheckApiManagementServiceNameAvailabilityAsync(ApiManagementServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckApiManagementServiceNameAvailability");
            scope.Start();
            try
            {
                var response = await ApiManagementServiceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks availability and correctness of a name for an API Management service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/checkNameAvailability
        /// Operation Id: ApiManagementService_CheckNameAvailability
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementServiceNameAvailabilityResult> CheckApiManagementServiceNameAvailability(ApiManagementServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckApiManagementServiceNameAvailability");
            scope.Start();
            try
            {
                var response = ApiManagementServiceRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain ownership identifier for an API Management service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/getDomainOwnershipIdentifier
        /// Operation Id: ApiManagementService_GetDomainOwnershipIdentifier
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementServiceGetDomainOwnershipIdentifierResult>> GetApiManagementServiceDomainOwnershipIdentifierAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServiceDomainOwnershipIdentifier");
            scope.Start();
            try
            {
                var response = await ApiManagementServiceRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the custom domain ownership identifier for an API Management service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/getDomainOwnershipIdentifier
        /// Operation Id: ApiManagementService_GetDomainOwnershipIdentifier
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementServiceGetDomainOwnershipIdentifierResult> GetApiManagementServiceDomainOwnershipIdentifier(CancellationToken cancellationToken = default)
        {
            using var scope = ApiManagementServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementServiceDomainOwnershipIdentifier");
            scope.Start();
            try
            {
                var response = ApiManagementServiceRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Microsoft.ApiManagement SKUs available for your Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/skus
        /// Operation Id: ApiManagementSkus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementSku> GetApiManagementSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementSku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementSkus");
                scope.Start();
                try
                {
                    var response = await ApiManagementSkusRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementSku>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementSkus");
                scope.Start();
                try
                {
                    var response = await ApiManagementSkusRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Microsoft.ApiManagement SKUs available for your Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ApiManagement/skus
        /// Operation Id: ApiManagementSkus_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementSku> GetApiManagementSkus(CancellationToken cancellationToken = default)
        {
            Page<ApiManagementSku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ApiManagementSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementSkus");
                scope.Start();
                try
                {
                    var response = ApiManagementSkusRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementSku> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ApiManagementSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetApiManagementSkus");
                scope.Start();
                try
                {
                    var response = ApiManagementSkusRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
