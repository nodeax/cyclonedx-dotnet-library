// This file is part of the CycloneDX Tool for .NET
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Copyright (c) Steve Springett. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CycloneDX.Models
{
    public class Service
    {
        [JsonPropertyName("bom-ref")]
        [XmlAttribute("bom-ref")]
        public string BomRef { get; set; }

        public OrganizationalEntity Provider { get; set; }

        public string Group { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string Description { get; set; }

        public List<string> Endpoints { get; set; }

        [XmlIgnore]
        public bool? Authenticated { get; set; }
        [XmlElement("authenticated")]
        [JsonIgnore]
        [Obsolete("Do not use directly, this is a serialization workaround.")]
        public bool NonNullableAuthenticated
        {
            get
            {
                return Authenticated.HasValue && Authenticated.Value;
            }
            set
            {
                Authenticated = value;
            }
        }
        public bool ShouldSerializeNonNullableAuthenticated() { return Authenticated.HasValue; }

        [XmlIgnore]
        [JsonPropertyName("x-trust-boundary")]
        public bool? XTrustBoundary { get; set; }
        [XmlElement("x-trust-boundary")]
        [JsonIgnore]
        [Obsolete("Do not use directly, this is a serialization workaround.")]
        public bool NonNullableXTrustBoundary
        {
            get
            {
                return XTrustBoundary.HasValue && XTrustBoundary.Value;
            }
            set
            {
                XTrustBoundary = value;
            }
        }
        public bool ShouldSerializeNonNullableXTrustBoundary() { return XTrustBoundary.HasValue; }

        public List<DataClassification> Data { get; set; }

        public List<ComponentLicense> Licenses { get; set; }

        public List<ExternalReference> ExternalReferences { get; set; }
    }
}