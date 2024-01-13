using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Converters
{
    internal class ResourceConverter<T> : JsonConverter<T>
        where T : IResource, new()
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            writer.WriteStartObject();
            foreach (var prop in props)
            {
                if (IsGeneric(prop, typeof(Join<>)) || IsGeneric(prop, typeof(Assoc<>)))
                    continue;

                var propVal = prop.GetValue(value);

                if (propVal is null)
                    continue;

                writer.WritePropertyName(prop.Name);
                JsonSerializer.Serialize(writer, propVal, options);
            }
            writer.WriteEndObject();
        }

        private bool IsGeneric(PropertyInfo prop, Type genericType)
        {
            return prop.PropertyType.IsGenericType
                && prop.PropertyType.GetGenericTypeDefinition().IsAssignableTo(typeof(Join<>));
        }
    }
}
