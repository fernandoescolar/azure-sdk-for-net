// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeVmMemory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartupMemoryInMB))
            {
                writer.WritePropertyName("startupMemoryMB");
                writer.WriteNumberValue(StartupMemoryInMB.Value);
            }
            if (Optional.IsDefined(CurrentMemoryUsageInMB))
            {
                writer.WritePropertyName("currentMemoryUsageMB");
                writer.WriteNumberValue(CurrentMemoryUsageInMB.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeVmMemory DeserializeDataBoxEdgeVmMemory(JsonElement element)
        {
            Optional<long> startupMemoryMB = default;
            Optional<long> currentMemoryUsageMB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startupMemoryMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startupMemoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("currentMemoryUsageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentMemoryUsageMB = property.Value.GetInt64();
                    continue;
                }
            }
            return new DataBoxEdgeVmMemory(Optional.ToNullable(startupMemoryMB), Optional.ToNullable(currentMemoryUsageMB));
        }
    }
}
