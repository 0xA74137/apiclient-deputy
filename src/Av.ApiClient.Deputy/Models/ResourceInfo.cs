using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Converters;

namespace Av.ApiClients.Deputy.Models
{
    public class ResourceInfo
    {
        [JsonPropertyName("fields")]
        [JsonConverter(typeof(DeputyDictionaryConverter<string, FieldType>))]
        public Dictionary<string, FieldType> Fields { get; set; } = new();

        [JsonPropertyName("joins")]
        [JsonConverter(typeof(DeputyDictionaryConverter<string, string>))]
        public Dictionary<string, string> Joins { get; set; } = new();

        [JsonPropertyName("assocs")]
        [JsonConverter(typeof(DeputyDictionaryConverter<string, string>))]
        public Dictionary<string, string> Associations { get; set; } = new();

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    [JsonConverter(typeof(FieldTypeConverter))]
    public enum FieldType
    {
        Unknown,
        Integer,
        Date,
        DateTime,
        Time,
        VarChar,
        Bit,
        Float,
        Blob,
        Json,
    }
}
