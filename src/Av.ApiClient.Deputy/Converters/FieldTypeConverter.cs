using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Models;

namespace Av.ApiClients.Deputy.Converters
{
    internal class FieldTypeConverter : JsonConverter<FieldType>
    {
        public override FieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString();
            if (!Enum.TryParse<FieldType>(x, ignoreCase: true, out var type))
                type = FieldType.Unknown;

            return type;
        }

        public override void Write(Utf8JsonWriter writer, FieldType value, JsonSerializerOptions options)
        {
            if (value == FieldType.Unknown)
                writer.WriteNullValue();

            writer.WriteStringValue(Enum.GetName(value));
        }
    }
}
