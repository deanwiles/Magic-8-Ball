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
using lro = Google.LongRunning;
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
    /// <summary>Settings for <see cref="ModelServiceClient"/> instances.</summary>
    public sealed partial class ModelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelServiceSettings"/>.</returns>
        public static ModelServiceSettings GetDefault() => new ModelServiceSettings();

        /// <summary>Constructs a new <see cref="ModelServiceSettings"/> object with default settings.</summary>
        public ModelServiceSettings()
        {
        }

        private ModelServiceSettings(ModelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetModelSettings = existing.GetModelSettings;
            ListModelsSettings = existing.ListModelsSettings;
            GetTunedModelSettings = existing.GetTunedModelSettings;
            ListTunedModelsSettings = existing.ListTunedModelsSettings;
            CreateTunedModelSettings = existing.CreateTunedModelSettings;
            CreateTunedModelOperationsSettings = existing.CreateTunedModelOperationsSettings.Clone();
            UpdateTunedModelSettings = existing.UpdateTunedModelSettings;
            DeleteTunedModelSettings = existing.DeleteTunedModelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ModelServiceClient.GetModel</c>
        ///  and <c>ModelServiceClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModels</c> and <c>ModelServiceClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.GetTunedModel</c> and <c>ModelServiceClient.GetTunedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTunedModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListTunedModels</c> and <c>ModelServiceClient.ListTunedModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTunedModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.CreateTunedModel</c> and <c>ModelServiceClient.CreateTunedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTunedModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.CreateTunedModel</c> and
        /// <c>ModelServiceClient.CreateTunedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateTunedModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.UpdateTunedModel</c> and <c>ModelServiceClient.UpdateTunedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTunedModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.DeleteTunedModel</c> and <c>ModelServiceClient.DeleteTunedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTunedModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ModelServiceSettings"/> object.</returns>
        public ModelServiceSettings Clone() => new ModelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ModelServiceClientBuilder : gaxgrpc::ClientBuilderBase<ModelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelServiceClientBuilder() : base(ModelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ModelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelServiceClient Build()
        {
            ModelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ModelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelServiceClient.ChannelPool;
    }

    /// <summary>ModelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for getting metadata information about Generative Models.
    /// </remarks>
    public abstract partial class ModelServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelService service, which is a host of "generativelanguage.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "generativelanguage.googleapis.com:443";

        /// <summary>The default ModelService scopes.</summary>
        /// <remarks>The default ModelService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ModelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelServiceClient"/>.</returns>
        public static stt::Task<ModelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        public static ModelServiceClient Create() => new ModelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        internal static ModelServiceClient Create(grpccore::CallInvoker callInvoker, ModelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelService.ModelServiceClient grpcClient = new ModelService.ModelServiceClient(callInvoker);
            return new ModelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ModelService client</summary>
        public virtual ModelService.ModelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// This name should match a model name returned by the `ListModels` method.
        /// 
        /// Format: `models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="pageSize">
        /// The maximum number of `Models` to return (per page).
        /// 
        /// The service may return fewer models.
        /// If unspecified, at most 50 models will be returned per page.
        /// This method returns at most 1000 models per page, even if you pass a larger
        /// page_size.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous `ListModels` call.
        /// 
        /// Provide the `page_token` returned by one request as an argument to the next
        /// request to retrieve the next page.
        /// 
        /// When paginating, all other parameters provided to `ListModels` must match
        /// the call that provided the page token.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        /* Remove redundant code: 
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        */
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(int pageSize, string pageToken,
            /* Remove redundant code: string pageToken = null, int? pageSize = null, */
            gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                PageSize = pageSize,
                PageToken = pageToken ?? "",
                /* Remove redundant code: 
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
                */
            }, callSettings);

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="pageSize">
        /// The maximum number of `Models` to return (per page).
        /// 
        /// The service may return fewer models.
        /// If unspecified, at most 50 models will be returned per page.
        /// This method returns at most 1000 models per page, even if you pass a larger
        /// page_size.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous `ListModels` call.
        /// 
        /// Provide the `page_token` returned by one request as an argument to the next
        /// request to retrieve the next page.
        /// 
        /// When paginating, all other parameters provided to `ListModels` must match
        /// the call that provided the page token.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        /* Remove redundant code: 
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        */
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(int pageSize, string pageToken,
            /* Remove redundant code: string pageToken = null, int? pageSize = null, */
            gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                PageSize = pageSize,
                PageToken = pageToken ?? "",
                /* Remove redundant code: 
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
                */
            }, callSettings);

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TunedModel GetTunedModel(GetTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(GetTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(GetTunedModelRequest request, st::CancellationToken cancellationToken) =>
            GetTunedModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TunedModel GetTunedModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTunedModel(new GetTunedModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTunedModelAsync(new GetTunedModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetTunedModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TunedModel GetTunedModel(TunedModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTunedModel(new GetTunedModelRequest
            {
                TunedModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(TunedModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTunedModelAsync(new GetTunedModelRequest
            {
                TunedModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// 
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> GetTunedModelAsync(TunedModelName name, st::CancellationToken cancellationToken) =>
            GetTunedModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TunedModel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModels(ListTunedModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TunedModel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModelsAsync(ListTunedModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="pageSize">
        /// Optional. The maximum number of `TunedModels` to return (per page).
        /// The service may return fewer tuned models.
        /// 
        /// If unspecified, at most 10 tuned models will be returned.
        /// This method returns at most 1000 models per page, even if you pass a larger
        /// page_size.
        /// </param>
        /// <param name="pageToken">
        /// Optional. A page token, received from a previous `ListTunedModels` call.
        /// 
        /// Provide the `page_token` returned by one request as an argument to the next
        /// request to retrieve the next page.
        /// 
        /// When paginating, all other parameters provided to `ListTunedModels`
        /// must match the call that provided the page token.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TunedModel"/> resources.</returns>
        /* Remove redundant code: 
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        */
        public virtual gax::PagedEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModels(int pageSize, string pageToken,
            /* Remove redundant code: string pageToken = null, int? pageSize = null, */
            gaxgrpc::CallSettings callSettings = null) =>
            ListTunedModels(new ListTunedModelsRequest
            {
                PageSize = pageSize,
                PageToken = pageToken ?? "",
                /* Remove redundant code: 
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
                */
            }, callSettings);

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="pageSize">
        /// Optional. The maximum number of `TunedModels` to return (per page).
        /// The service may return fewer tuned models.
        /// 
        /// If unspecified, at most 10 tuned models will be returned.
        /// This method returns at most 1000 models per page, even if you pass a larger
        /// page_size.
        /// </param>
        /// <param name="pageToken">
        /// Optional. A page token, received from a previous `ListTunedModels` call.
        /// 
        /// Provide the `page_token` returned by one request as an argument to the next
        /// request to retrieve the next page.
        /// 
        /// When paginating, all other parameters provided to `ListTunedModels`
        /// must match the call that provided the page token.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TunedModel"/> resources.</returns>
        /* Remove redundant code: 
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        */
        public virtual gax::PagedAsyncEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModelsAsync(int pageSize, string pageToken,
            /* Remove redundant code: string pageToken = null, int? pageSize = null, */
            gaxgrpc::CallSettings callSettings = null) =>
            ListTunedModelsAsync(new ListTunedModelsRequest
            {
                PageSize = pageSize,
                PageToken = pageToken ?? "",
                /* Remove redundant code: 
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
                */
            }, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TunedModel, CreateTunedModelMetadata> CreateTunedModel(CreateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(CreateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(CreateTunedModelRequest request, st::CancellationToken cancellationToken) =>
            CreateTunedModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTunedModel</c>.</summary>
        public virtual lro::OperationsClient CreateTunedModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTunedModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TunedModel, CreateTunedModelMetadata> PollOnceCreateTunedModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TunedModel, CreateTunedModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTunedModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTunedModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> PollOnceCreateTunedModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TunedModel, CreateTunedModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTunedModelOperationsClient, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TunedModel, CreateTunedModelMetadata> CreateTunedModel(TunedModel tunedModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateTunedModel(new CreateTunedModelRequest
            {
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
            }, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(TunedModel tunedModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateTunedModelAsync(new CreateTunedModelRequest
            {
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
            }, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(TunedModel tunedModel, st::CancellationToken cancellationToken) =>
            CreateTunedModelAsync(tunedModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModelId">
        /// Optional. The unique id for the tuned model if specified.
        /// This value should be up to 40 characters, the first character must be a
        /// letter, the last could be a letter or a number. The id must match the
        /// regular expression: [a-z]([a-z0-9-]{0,38}[a-z0-9])?.
        /// </param>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TunedModel, CreateTunedModelMetadata> CreateTunedModel(string tunedModelId, TunedModel tunedModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateTunedModel(new CreateTunedModelRequest
            {
                TunedModelId = tunedModelId ?? "",
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
            }, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModelId">
        /// Optional. The unique id for the tuned model if specified.
        /// This value should be up to 40 characters, the first character must be a
        /// letter, the last could be a letter or a number. The id must match the
        /// regular expression: [a-z]([a-z0-9-]{0,38}[a-z0-9])?.
        /// </param>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(string tunedModelId, TunedModel tunedModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateTunedModelAsync(new CreateTunedModelRequest
            {
                TunedModelId = tunedModelId ?? "",
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
            }, callSettings);

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModelId">
        /// Optional. The unique id for the tuned model if specified.
        /// This value should be up to 40 characters, the first character must be a
        /// letter, the last could be a letter or a number. The id must match the
        /// regular expression: [a-z]([a-z0-9-]{0,38}[a-z0-9])?.
        /// </param>
        /// <param name="tunedModel">
        /// Required. The tuned model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(string tunedModelId, TunedModel tunedModel, st::CancellationToken cancellationToken) =>
            CreateTunedModelAsync(tunedModelId, tunedModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TunedModel UpdateTunedModel(UpdateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> UpdateTunedModelAsync(UpdateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> UpdateTunedModelAsync(UpdateTunedModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateTunedModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TunedModel UpdateTunedModel(TunedModel tunedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTunedModel(new UpdateTunedModelRequest
            {
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> UpdateTunedModelAsync(TunedModel tunedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTunedModelAsync(new UpdateTunedModelRequest
            {
                TunedModel = gax::GaxPreconditions.CheckNotNull(tunedModel, nameof(tunedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="tunedModel">
        /// Required. The tuned model to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TunedModel> UpdateTunedModelAsync(TunedModel tunedModel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTunedModelAsync(tunedModel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTunedModel(DeleteTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(DeleteTunedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(DeleteTunedModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteTunedModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTunedModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTunedModel(new DeleteTunedModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTunedModelAsync(new DeleteTunedModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTunedModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTunedModel(TunedModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTunedModel(new DeleteTunedModelRequest
            {
                TunedModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(TunedModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTunedModelAsync(new DeleteTunedModelRequest
            {
                TunedModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model.
        /// Format: `tunedModels/my-model-id`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTunedModelAsync(TunedModelName name, st::CancellationToken cancellationToken) =>
            DeleteTunedModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ModelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for getting metadata information about Generative Models.
    /// </remarks>
    public sealed partial class ModelServiceClientImpl : ModelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<GetTunedModelRequest, TunedModel> _callGetTunedModel;

        private readonly gaxgrpc::ApiCall<ListTunedModelsRequest, ListTunedModelsResponse> _callListTunedModels;

        private readonly gaxgrpc::ApiCall<CreateTunedModelRequest, lro::Operation> _callCreateTunedModel;

        private readonly gaxgrpc::ApiCall<UpdateTunedModelRequest, TunedModel> _callUpdateTunedModel;

        private readonly gaxgrpc::ApiCall<DeleteTunedModelRequest, wkt::Empty> _callDeleteTunedModel;

        /// <summary>
        /// Constructs a client wrapper for the ModelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ModelServiceClientImpl(ModelService.ModelServiceClient grpcClient, ModelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ModelServiceSettings effectiveSettings = settings ?? ModelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateTunedModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTunedModelOperationsSettings, logger);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>("GetModel", grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>("ListModels", grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callGetTunedModel = clientHelper.BuildApiCall<GetTunedModelRequest, TunedModel>("GetTunedModel", grpcClient.GetTunedModelAsync, grpcClient.GetTunedModel, effectiveSettings.GetTunedModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTunedModel);
            Modify_GetTunedModelApiCall(ref _callGetTunedModel);
            _callListTunedModels = clientHelper.BuildApiCall<ListTunedModelsRequest, ListTunedModelsResponse>("ListTunedModels", grpcClient.ListTunedModelsAsync, grpcClient.ListTunedModels, effectiveSettings.ListTunedModelsSettings);
            Modify_ApiCall(ref _callListTunedModels);
            Modify_ListTunedModelsApiCall(ref _callListTunedModels);
            _callCreateTunedModel = clientHelper.BuildApiCall<CreateTunedModelRequest, lro::Operation>("CreateTunedModel", grpcClient.CreateTunedModelAsync, grpcClient.CreateTunedModel, effectiveSettings.CreateTunedModelSettings);
            Modify_ApiCall(ref _callCreateTunedModel);
            Modify_CreateTunedModelApiCall(ref _callCreateTunedModel);
            _callUpdateTunedModel = clientHelper.BuildApiCall<UpdateTunedModelRequest, TunedModel>("UpdateTunedModel", grpcClient.UpdateTunedModelAsync, grpcClient.UpdateTunedModel, effectiveSettings.UpdateTunedModelSettings).WithGoogleRequestParam("tuned_model.name", request => request.TunedModel?.Name);
            Modify_ApiCall(ref _callUpdateTunedModel);
            Modify_UpdateTunedModelApiCall(ref _callUpdateTunedModel);
            _callDeleteTunedModel = clientHelper.BuildApiCall<DeleteTunedModelRequest, wkt::Empty>("DeleteTunedModel", grpcClient.DeleteTunedModelAsync, grpcClient.DeleteTunedModel, effectiveSettings.DeleteTunedModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTunedModel);
            Modify_DeleteTunedModelApiCall(ref _callDeleteTunedModel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_GetTunedModelApiCall(ref gaxgrpc::ApiCall<GetTunedModelRequest, TunedModel> call);

        partial void Modify_ListTunedModelsApiCall(ref gaxgrpc::ApiCall<ListTunedModelsRequest, ListTunedModelsResponse> call);

        partial void Modify_CreateTunedModelApiCall(ref gaxgrpc::ApiCall<CreateTunedModelRequest, lro::Operation> call);

        partial void Modify_UpdateTunedModelApiCall(ref gaxgrpc::ApiCall<UpdateTunedModelRequest, TunedModel> call);

        partial void Modify_DeleteTunedModelApiCall(ref gaxgrpc::ApiCall<DeleteTunedModelRequest, wkt::Empty> call);

        partial void OnConstruction(ModelService.ModelServiceClient grpcClient, ModelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelService client</summary>
        public override ModelService.ModelServiceClient GrpcClient { get; }

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTunedModelRequest(ref GetTunedModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTunedModelsRequest(ref ListTunedModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTunedModelRequest(ref CreateTunedModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTunedModelRequest(ref UpdateTunedModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTunedModelRequest(ref DeleteTunedModelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists models available through the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TunedModel GetTunedModel(GetTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTunedModelRequest(ref request, ref callSettings);
            return _callGetTunedModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a specific TunedModel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TunedModel> GetTunedModelAsync(GetTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTunedModelRequest(ref request, ref callSettings);
            return _callGetTunedModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TunedModel"/> resources.</returns>
        public override gax::PagedEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModels(ListTunedModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTunedModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTunedModelsRequest, ListTunedModelsResponse, TunedModel>(_callListTunedModels, request, callSettings);
        }

        /// <summary>
        /// Lists tuned models owned by the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TunedModel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTunedModelsResponse, TunedModel> ListTunedModelsAsync(ListTunedModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTunedModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTunedModelsRequest, ListTunedModelsResponse, TunedModel>(_callListTunedModels, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTunedModel</c>.</summary>
        public override lro::OperationsClient CreateTunedModelOperationsClient { get; }

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TunedModel, CreateTunedModelMetadata> CreateTunedModel(CreateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTunedModelRequest(ref request, ref callSettings);
            return new lro::Operation<TunedModel, CreateTunedModelMetadata>(_callCreateTunedModel.Sync(request, callSettings), CreateTunedModelOperationsClient);
        }

        /// <summary>
        /// Creates a tuned model.
        /// Intermediate tuning progress (if any) is accessed through the
        /// [google.longrunning.Operations] service.
        /// 
        /// Status and results can be accessed through the Operations service.
        /// Example:
        /// GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TunedModel, CreateTunedModelMetadata>> CreateTunedModelAsync(CreateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTunedModelRequest(ref request, ref callSettings);
            return new lro::Operation<TunedModel, CreateTunedModelMetadata>(await _callCreateTunedModel.Async(request, callSettings).ConfigureAwait(false), CreateTunedModelOperationsClient);
        }

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TunedModel UpdateTunedModel(UpdateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTunedModelRequest(ref request, ref callSettings);
            return _callUpdateTunedModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TunedModel> UpdateTunedModelAsync(UpdateTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTunedModelRequest(ref request, ref callSettings);
            return _callUpdateTunedModel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTunedModel(DeleteTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTunedModelRequest(ref request, ref callSettings);
            _callDeleteTunedModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTunedModelAsync(DeleteTunedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTunedModelRequest(ref request, ref callSettings);
            return _callDeleteTunedModel.Async(request, callSettings);
        }
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTunedModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTunedModelsResponse : gaxgrpc::IPageResponse<TunedModel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TunedModel> GetEnumerator() => TunedModels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ModelService
    {
        public partial class ModelServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
