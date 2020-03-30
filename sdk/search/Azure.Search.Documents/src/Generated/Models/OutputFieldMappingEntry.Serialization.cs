// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class OutputFieldMappingEntry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (TargetName != null)
            {
                writer.WritePropertyName("targetName");
                writer.WriteStringValue(TargetName);
            }
            writer.WriteEndObject();
        }

        internal static OutputFieldMappingEntry DeserializeOutputFieldMappingEntry(JsonElement element)
        {
            string name = default;
            string targetName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetName = property.Value.GetString();
                    continue;
                }
            }
            return new OutputFieldMappingEntry(name, targetName);
        }
    }
}