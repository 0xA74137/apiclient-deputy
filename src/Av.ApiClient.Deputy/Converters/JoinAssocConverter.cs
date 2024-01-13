using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Converters
{
    internal class JoinConverter<TRes> : JsonConverter<Join<TRes>>
        where TRes : IResource, new()
    {
        public override Join<TRes>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var t = JsonSerializer.Deserialize<TRes>(ref reader, options);
            if (t is null)
                return null;

            return new Join<TRes>() { Value = t };
        }

        public override void Write(Utf8JsonWriter writer, Join<TRes> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Value, options);
        }
    }

    internal class AssocConverter<TRes> : JsonConverter<Assoc<TRes>>
        where TRes : IResource, new()
    {
        public override Assoc<TRes>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var t = JsonSerializer.Deserialize<TRes>(ref reader, options);
            if (t is null)
                return null;

            return new Assoc<TRes>() { Value = t };
        }

        public override void Write(Utf8JsonWriter writer, Assoc<TRes> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Value, options);
        }
    }
}
