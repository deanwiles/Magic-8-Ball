// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ai.Generativelanguage.V1Beta3
{
    /// <summary>Settings for <see cref="PermissionServiceClient"/> instances.</summary>
    public sealed partial class PermissionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PermissionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PermissionServiceSettings"/>.</returns>
        public static PermissionServiceSettings GetDefault() => new PermissionServiceSettings();

        /// <summary>Constructs a new <see cref="PermissionServiceSettings"/> object with default settings.</summary>
        public PermissionServiceSettings()
        {
        }

        private PermissionServiceSettings(PermissionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePermissionSettings = existing.CreatePermissionSettings;
            GetPermissionSettings = existing.GetPermissionSettings;
            ListPermissionsSettings = existing.ListPermissionsSettings;
            UpdatePermissionSettings = existing.UpdatePermissionSettings;
            DeletePermissionSettings = existing.DeletePermissionSettings;
            TransferOwnershipSettings = existing.TransferOwnershipSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PermissionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.CreatePermission</c> and <c>PermissionServiceClient.CreatePermissionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePermissionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.GetPermission</c> and <c>PermissionServiceClient.GetPermissionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPermissionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.ListPermissions</c> and <c>PermissionServiceClient.ListPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.UpdatePermission</c> and <c>PermissionServiceClient.UpdatePermissionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePermissionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.DeletePermission</c> and <c>PermissionServiceClient.DeletePermissionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePermissionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PermissionServiceClient.TransferOwnership</c> and <c>PermissionServiceClient.TransferOwnershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TransferOwnershipSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PermissionServiceSettings"/> object.</returns>
        public PermissionServiceSettings Clone() => new PermissionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PermissionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PermissionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PermissionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PermissionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PermissionServiceClientBuilder() : base(PermissionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PermissionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PermissionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PermissionServiceClient Build()
        {
            PermissionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PermissionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PermissionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PermissionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PermissionServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<PermissionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PermissionServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PermissionServiceClient.ChannelPool;
    }

    /// <summary>PermissionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for managing permissions to PaLM API resources.
    /// </remarks>
    public abstract partial class PermissionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PermissionService service, which is a host of
        /// "generativelanguage.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "generativelanguage.googleapis.com:443";

        /// <summary>The default PermissionService scopes.</summary>
        /// <remarks>The default PermissionService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PermissionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PermissionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PermissionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PermissionServiceClient"/>.</returns>
        public static stt::Task<PermissionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PermissionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PermissionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PermissionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PermissionServiceClient"/>.</returns>
        public static PermissionServiceClient Create() => new PermissionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PermissionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PermissionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PermissionServiceClient"/>.</returns>
        internal static PermissionServiceClient Create(grpccore::CallInvoker callInvoker, PermissionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PermissionService.PermissionServiceClient grpcClient = new PermissionService.PermissionServiceClient(callInvoker);
            return new PermissionServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC PermissionService client</summary>
        public virtual PermissionService.PermissionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission CreatePermission(CreatePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(CreatePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(CreatePermissionRequest request, st::CancellationToken cancellationToken) =>
            CreatePermissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission CreatePermission(string parent, Permission permission, gaxgrpc::CallSettings callSettings = null) =>
            CreatePermission(new CreatePermissionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
            }, callSettings);

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(string parent, Permission permission, gaxgrpc::CallSettings callSettings = null) =>
            CreatePermissionAsync(new CreatePermissionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
            }, callSettings);

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(string parent, Permission permission, st::CancellationToken cancellationToken) =>
            CreatePermissionAsync(parent, permission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission CreatePermission(TunedModelName parent, Permission permission, gaxgrpc::CallSettings callSettings = null) =>
            CreatePermission(new CreatePermissionRequest
            {
                ParentAsTunedModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
            }, callSettings);

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(TunedModelName parent, Permission permission, gaxgrpc::CallSettings callSettings = null) =>
            CreatePermissionAsync(new CreatePermissionRequest
            {
                ParentAsTunedModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
            }, callSettings);

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `Permission`.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="permission">
        /// Required. The permission to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> CreatePermissionAsync(TunedModelName parent, Permission permission, st::CancellationToken cancellationToken) =>
            CreatePermissionAsync(parent, permission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission GetPermission(GetPermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(GetPermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(GetPermissionRequest request, st::CancellationToken cancellationToken) =>
            GetPermissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission GetPermission(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPermission(new GetPermissionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPermissionAsync(new GetPermissionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPermissionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission GetPermission(PermissionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPermission(new GetPermissionRequest
            {
                PermissionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(PermissionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPermissionAsync(new GetPermissionRequest
            {
                PermissionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// 
        /// Format: `tunedModels/{tuned_model}permissions/{permission}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> GetPermissionAsync(PermissionName name, st::CancellationToken cancellationToken) =>
            GetPermissionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermissionsResponse, Permission> ListPermissions(ListPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermissionsResponse, Permission> ListPermissionsAsync(ListPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the permissions.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermissionsResponse, Permission> ListPermissions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPermissions(new ListPermissionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the permissions.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermissionsResponse, Permission> ListPermissionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPermissionsAsync(new ListPermissionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the permissions.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPermissionsResponse, Permission> ListPermissions(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPermissions(new ListPermissionsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the permissions.
        /// Format: tunedModels/{tuned_model}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPermissionsResponse, Permission> ListPermissionsAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPermissionsAsync(new ListPermissionsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission UpdatePermission(UpdatePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> UpdatePermissionAsync(UpdatePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> UpdatePermissionAsync(UpdatePermissionRequest request, st::CancellationToken cancellationToken) =>
            UpdatePermissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="permission">
        /// Required. The permission to update.
        /// 
        /// The permission's `name` field is used to identify the permission to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Accepted ones:
        /// - role (`Permission.role` field)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Permission UpdatePermission(Permission permission, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePermission(new UpdatePermissionRequest
            {
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="permission">
        /// Required. The permission to update.
        /// 
        /// The permission's `name` field is used to identify the permission to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Accepted ones:
        /// - role (`Permission.role` field)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> UpdatePermissionAsync(Permission permission, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePermissionAsync(new UpdatePermissionRequest
            {
                Permission = gax::GaxPreconditions.CheckNotNull(permission, nameof(permission)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="permission">
        /// Required. The permission to update.
        /// 
        /// The permission's `name` field is used to identify the permission to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. Accepted ones:
        /// - role (`Permission.role` field)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Permission> UpdatePermissionAsync(Permission permission, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePermissionAsync(permission, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePermission(DeletePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(DeletePermissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(DeletePermissionRequest request, st::CancellationToken cancellationToken) =>
            DeletePermissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePermission(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePermission(new DeletePermissionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePermissionAsync(new DeletePermissionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePermissionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePermission(PermissionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePermission(new DeletePermissionRequest
            {
                PermissionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(PermissionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePermissionAsync(new DeletePermissionRequest
            {
                PermissionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the permission.
        /// Format: `tunedModels/{tuned_model}/permissions/{permission}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePermissionAsync(PermissionName name, st::CancellationToken cancellationToken) =>
            DeletePermissionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Transfers ownership of the tuned model.
        /// This is the only way to change ownership of the tuned model.
        /// The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferOwnershipResponse TransferOwnership(TransferOwnershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers ownership of the tuned model.
        /// This is the only way to change ownership of the tuned model.
        /// The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferOwnershipResponse> TransferOwnershipAsync(TransferOwnershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers ownership of the tuned model.
        /// This is the only way to change ownership of the tuned model.
        /// The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferOwnershipResponse> TransferOwnershipAsync(TransferOwnershipRequest request, st::CancellationToken cancellationToken) =>
            TransferOwnershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PermissionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for managing permissions to PaLM API resources.
    /// </remarks>
    public sealed partial class PermissionServiceClientImpl : PermissionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreatePermissionRequest, Permission> _callCreatePermission;

        private readonly gaxgrpc::ApiCall<GetPermissionRequest, Permission> _callGetPermission;

        private readonly gaxgrpc::ApiCall<ListPermissionsRequest, ListPermissionsResponse> _callListPermissions;

        private readonly gaxgrpc::ApiCall<UpdatePermissionRequest, Permission> _callUpdatePermission;

        private readonly gaxgrpc::ApiCall<DeletePermissionRequest, wkt::Empty> _callDeletePermission;

        private readonly gaxgrpc::ApiCall<TransferOwnershipRequest, TransferOwnershipResponse> _callTransferOwnership;

        /// <summary>
        /// Constructs a client wrapper for the PermissionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PermissionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PermissionServiceClientImpl(PermissionService.PermissionServiceClient grpcClient, PermissionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PermissionServiceSettings effectiveSettings = settings ?? PermissionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreatePermission = clientHelper.BuildApiCall<CreatePermissionRequest, Permission>("CreatePermission", grpcClient.CreatePermissionAsync, grpcClient.CreatePermission, effectiveSettings.CreatePermissionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePermission);
            Modify_CreatePermissionApiCall(ref _callCreatePermission);
            _callGetPermission = clientHelper.BuildApiCall<GetPermissionRequest, Permission>("GetPermission", grpcClient.GetPermissionAsync, grpcClient.GetPermission, effectiveSettings.GetPermissionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPermission);
            Modify_GetPermissionApiCall(ref _callGetPermission);
            _callListPermissions = clientHelper.BuildApiCall<ListPermissionsRequest, ListPermissionsResponse>("ListPermissions", grpcClient.ListPermissionsAsync, grpcClient.ListPermissions, effectiveSettings.ListPermissionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPermissions);
            Modify_ListPermissionsApiCall(ref _callListPermissions);
            _callUpdatePermission = clientHelper.BuildApiCall<UpdatePermissionRequest, Permission>("UpdatePermission", grpcClient.UpdatePermissionAsync, grpcClient.UpdatePermission, effectiveSettings.UpdatePermissionSettings).WithGoogleRequestParam("permission.name", request => request.Permission?.Name);
            Modify_ApiCall(ref _callUpdatePermission);
            Modify_UpdatePermissionApiCall(ref _callUpdatePermission);
            _callDeletePermission = clientHelper.BuildApiCall<DeletePermissionRequest, wkt::Empty>("DeletePermission", grpcClient.DeletePermissionAsync, grpcClient.DeletePermission, effectiveSettings.DeletePermissionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePermission);
            Modify_DeletePermissionApiCall(ref _callDeletePermission);
            _callTransferOwnership = clientHelper.BuildApiCall<TransferOwnershipRequest, TransferOwnershipResponse>("TransferOwnership", grpcClient.TransferOwnershipAsync, grpcClient.TransferOwnership, effectiveSettings.TransferOwnershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTransferOwnership);
            Modify_TransferOwnershipApiCall(ref _callTransferOwnership);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePermissionApiCall(ref gaxgrpc::ApiCall<CreatePermissionRequest, Permission> call);

        partial void Modify_GetPermissionApiCall(ref gaxgrpc::ApiCall<GetPermissionRequest, Permission> call);

        partial void Modify_ListPermissionsApiCall(ref gaxgrpc::ApiCall<ListPermissionsRequest, ListPermissionsResponse> call);

        partial void Modify_UpdatePermissionApiCall(ref gaxgrpc::ApiCall<UpdatePermissionRequest, Permission> call);

        partial void Modify_DeletePermissionApiCall(ref gaxgrpc::ApiCall<DeletePermissionRequest, wkt::Empty> call);

        partial void Modify_TransferOwnershipApiCall(ref gaxgrpc::ApiCall<TransferOwnershipRequest, TransferOwnershipResponse> call);

        partial void OnConstruction(PermissionService.PermissionServiceClient grpcClient, PermissionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PermissionService client</summary>
        public override PermissionService.PermissionServiceClient GrpcClient { get; }

        partial void Modify_CreatePermissionRequest(ref CreatePermissionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPermissionRequest(ref GetPermissionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPermissionsRequest(ref ListPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePermissionRequest(ref UpdatePermissionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePermissionRequest(ref DeletePermissionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TransferOwnershipRequest(ref TransferOwnershipRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Permission CreatePermission(CreatePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePermissionRequest(ref request, ref callSettings);
            return _callCreatePermission.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Permission> CreatePermissionAsync(CreatePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePermissionRequest(ref request, ref callSettings);
            return _callCreatePermission.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Permission GetPermission(GetPermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPermissionRequest(ref request, ref callSettings);
            return _callGetPermission.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Permission> GetPermissionAsync(GetPermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPermissionRequest(ref request, ref callSettings);
            return _callGetPermission.Async(request, callSettings);
        }

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Permission"/> resources.</returns>
        public override gax::PagedEnumerable<ListPermissionsResponse, Permission> ListPermissions(ListPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPermissionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPermissionsRequest, ListPermissionsResponse, Permission>(_callListPermissions, request, callSettings);
        }

        /// <summary>
        /// Lists permissions for the specific resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Permission"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPermissionsResponse, Permission> ListPermissionsAsync(ListPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPermissionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPermissionsRequest, ListPermissionsResponse, Permission>(_callListPermissions, request, callSettings);
        }

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Permission UpdatePermission(UpdatePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePermissionRequest(ref request, ref callSettings);
            return _callUpdatePermission.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Permission> UpdatePermissionAsync(UpdatePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePermissionRequest(ref request, ref callSettings);
            return _callUpdatePermission.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePermission(DeletePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePermissionRequest(ref request, ref callSettings);
            _callDeletePermission.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePermissionAsync(DeletePermissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePermissionRequest(ref request, ref callSettings);
            return _callDeletePermission.Async(request, callSettings);
        }

        /// <summary>
        /// Transfers ownership of the tuned model.
        /// This is the only way to change ownership of the tuned model.
        /// The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferOwnershipResponse TransferOwnership(TransferOwnershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferOwnershipRequest(ref request, ref callSettings);
            return _callTransferOwnership.Sync(request, callSettings);
        }

        /// <summary>
        /// Transfers ownership of the tuned model.
        /// This is the only way to change ownership of the tuned model.
        /// The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferOwnershipResponse> TransferOwnershipAsync(TransferOwnershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferOwnershipRequest(ref request, ref callSettings);
            return _callTransferOwnership.Async(request, callSettings);
        }
    }

    public partial class ListPermissionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPermissionsResponse : gaxgrpc::IPageResponse<Permission>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Permission> GetEnumerator() => Permissions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
