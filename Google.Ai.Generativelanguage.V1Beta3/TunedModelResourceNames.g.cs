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
using sys = System;

namespace Google.Ai.Generativelanguage.V1Beta3
{
    /// <summary>Resource name for the <c>TunedModel</c> resource.</summary>
    public sealed partial class TunedModelName : gax::IResourceName, sys::IEquatable<TunedModelName>
    {
        /// <summary>The possible contents of <see cref="TunedModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tunedModels/{tuned_model}</c>.</summary>
            TunedModel = 1,
        }

        private static gax::PathTemplate s_tunedModel = new gax::PathTemplate("tunedModels/{tuned_model}");

        /// <summary>Creates a <see cref="TunedModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TunedModelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TunedModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TunedModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="TunedModelName"/> with the pattern <c>tunedModels/{tuned_model}</c>.</summary>
        /// <param name="tunedModelId">The <c>TunedModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TunedModelName"/> constructed from the provided ids.</returns>
        public static TunedModelName FromTunedModel(string tunedModelId) =>
            new TunedModelName(ResourceNameType.TunedModel, tunedModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(tunedModelId, nameof(tunedModelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunedModelName"/> with pattern
        /// <c>tunedModels/{tuned_model}</c>.
        /// </summary>
        /// <param name="tunedModelId">The <c>TunedModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunedModelName"/> with pattern <c>tunedModels/{tuned_model}</c>
        /// .
        /// </returns>
        public static string Format(string tunedModelId) => FormatTunedModel(tunedModelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunedModelName"/> with pattern
        /// <c>tunedModels/{tuned_model}</c>.
        /// </summary>
        /// <param name="tunedModelId">The <c>TunedModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunedModelName"/> with pattern <c>tunedModels/{tuned_model}</c>
        /// .
        /// </returns>
        public static string FormatTunedModel(string tunedModelId) =>
            s_tunedModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tunedModelId, nameof(tunedModelId)));

        /// <summary>Parses the given resource name string into a new <see cref="TunedModelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tunedModels/{tuned_model}</c></description></item></list>
        /// </remarks>
        /// <param name="tunedModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TunedModelName"/> if successful.</returns>
        public static TunedModelName Parse(string tunedModelName) => Parse(tunedModelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TunedModelName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tunedModels/{tuned_model}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunedModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TunedModelName"/> if successful.</returns>
        public static TunedModelName Parse(string tunedModelName, bool allowUnparsed) =>
            TryParse(tunedModelName, allowUnparsed, out TunedModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunedModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tunedModels/{tuned_model}</c></description></item></list>
        /// </remarks>
        /// <param name="tunedModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunedModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunedModelName, out TunedModelName result) =>
            TryParse(tunedModelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunedModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tunedModels/{tuned_model}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunedModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunedModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunedModelName, bool allowUnparsed, out TunedModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(tunedModelName, nameof(tunedModelName));
            gax::TemplatedResourceName resourceName;
            if (s_tunedModel.TryParseName(tunedModelName, out resourceName))
            {
                result = FromTunedModel(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tunedModelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TunedModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tunedModelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TunedModelId = tunedModelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TunedModelName"/> class from the component parts of pattern
        /// <c>tunedModels/{tuned_model}</c>
        /// </summary>
        /// <param name="tunedModelId">The <c>TunedModel</c> ID. Must not be <c>null</c> or empty.</param>
        public TunedModelName(string tunedModelId) : this(ResourceNameType.TunedModel, tunedModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(tunedModelId, nameof(tunedModelId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>TunedModel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TunedModelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TunedModel: return s_tunedModel.Expand(TunedModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TunedModelName);

        /// <inheritdoc/>
        public bool Equals(TunedModelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TunedModelName a, TunedModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TunedModelName a, TunedModelName b) => !(a == b);
    }

    public partial class TunedModel
    {
        /// <summary>
        /// <see cref="gagv::TunedModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagv::TunedModelName TunedModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagv::TunedModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ModelName"/>-typed view over the <see cref="BaseModel"/> resource name property.
        /// </summary>
        public ModelName BaseModelAsModelName
        {
            get => string.IsNullOrEmpty(BaseModel) ? null : ModelName.Parse(BaseModel, allowUnparsed: true);
            set => BaseModel = value?.ToString() ?? "";
        }
    }

    public partial class TunedModelSource
    {
        /// <summary>
        /// <see cref="TunedModelName"/>-typed view over the <see cref="TunedModel"/> resource name property.
        /// </summary>
        public TunedModelName TunedModelAsTunedModelName
        {
            get => string.IsNullOrEmpty(TunedModel) ? null : TunedModelName.Parse(TunedModel, allowUnparsed: true);
            set => TunedModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ModelName"/>-typed view over the <see cref="BaseModel"/> resource name property.
        /// </summary>
        public ModelName BaseModelAsModelName
        {
            get => string.IsNullOrEmpty(BaseModel) ? null : ModelName.Parse(BaseModel, allowUnparsed: true);
            set => BaseModel = value?.ToString() ?? "";
        }
    }
}
