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
using gagv = Google.Ai.Generativelanguage.V1Beta3;
using gax = Google.Api.Gax;

namespace Google.Ai.Generativelanguage.V1Beta3
{
    public partial class CreatePermissionRequest
    {
        /// <summary>
        /// <see cref="TunedModelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TunedModelName ParentAsTunedModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TunedModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPermissionRequest
    {
        /// <summary>
        /// <see cref="gagv::PermissionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagv::PermissionName PermissionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagv::PermissionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPermissionsRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gax::UnparsedResourceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePermissionRequest
    {
        /// <summary>
        /// <see cref="gagv::PermissionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagv::PermissionName PermissionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagv::PermissionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TransferOwnershipRequest
    {
        /// <summary>
        /// <see cref="gagv::TunedModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagv::TunedModelName TunedModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagv::TunedModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
