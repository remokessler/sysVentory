using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions.Types.Deserializer
{
    internal class ScanInformationConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IEnumerable<IScanInformation>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(ScanInformation[]));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(ScanInformation[]));
        }
    }
}
