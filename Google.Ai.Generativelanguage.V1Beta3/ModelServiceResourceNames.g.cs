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

namespace Google.Ai.Generativelanguage.V1Beta3
{
    public partial class GetModelRequest
    {
        /// <summary>
        /// <see cref="gagv::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagv::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagv::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTunedModelRequest
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

    public partial class CreateTunedModelMetadata
    {
        /// <summary>
        /// <see cref="TunedModelName"/>-typed view over the <see cref="TunedModel"/> resource name property.
        /// </summary>
        public TunedModelName TunedModelAsTunedModelName
        {
            get => string.IsNullOrEmpty(TunedModel) ? null : TunedModelName.Parse(TunedModel, allowUnparsed: true);
            set => TunedModel = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTunedModelRequest
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
