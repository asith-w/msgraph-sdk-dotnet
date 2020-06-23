// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IServicePrincipalRequestBuilder.
    /// </summary>
    public partial interface IServicePrincipalRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IServicePrincipalRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IServicePrincipalRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AppRoleAssignedTo.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignedToCollectionRequestBuilder"/>.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequestBuilder AppRoleAssignedTo { get; }

        /// <summary>
        /// Gets the request builder for AppRoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IServicePrincipalAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for ClaimsMappingPolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesRequestBuilder ClaimsMappingPolicies { get; }

        /// <summary>
        /// Gets the request builder for Endpoints.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalEndpointsCollectionRequestBuilder"/>.</returns>
        IServicePrincipalEndpointsCollectionRequestBuilder Endpoints { get; }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder HomeRealmDiscoveryPolicies { get; }

        /// <summary>
        /// Gets the request builder for Oauth2PermissionGrants.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder Oauth2PermissionGrants { get; }

        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf { get; }

        /// <summary>
        /// Gets the request builder for CreatedObjects.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalCreatedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalCreatedObjectsCollectionWithReferencesRequestBuilder CreatedObjects { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for OwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOwnedObjectsCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalOwnedObjectsCollectionWithReferencesRequestBuilder OwnedObjects { get; }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesRequestBuilder TokenIssuancePolicies { get; }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder TokenLifetimePolicies { get; }
    
        /// <summary>
        /// Gets the request builder for ServicePrincipalAddKey.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAddKeyRequestBuilder"/>.</returns>
        IServicePrincipalAddKeyRequestBuilder AddKey(
            KeyCredential keyCredential,
            string proof,
            PasswordCredential passwordCredential = null);

        /// <summary>
        /// Gets the request builder for ServicePrincipalAddPassword.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAddPasswordRequestBuilder"/>.</returns>
        IServicePrincipalAddPasswordRequestBuilder AddPassword(
            PasswordCredential passwordCredential = null);

        /// <summary>
        /// Gets the request builder for ServicePrincipalRemoveKey.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalRemoveKeyRequestBuilder"/>.</returns>
        IServicePrincipalRemoveKeyRequestBuilder RemoveKey(
            Guid keyId,
            string proof);

        /// <summary>
        /// Gets the request builder for ServicePrincipalRemovePassword.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalRemovePasswordRequestBuilder"/>.</returns>
        IServicePrincipalRemovePasswordRequestBuilder RemovePassword(
            Guid keyId);
    
    }
}