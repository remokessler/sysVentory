using Newtonsoft.Json;
using System.Collections.Generic;
using sysVentory.Model.Definitions.Types.Deserializer;

namespace sysVentory.Model.Definitions.Types
{
    internal class Computer : IComputer
    {
        public string Name { get; set; }
        public string MacAddress { get; set; }

        [JsonConverter(typeof(ScanConverter))]
        public IEnumerable<IScan> Scans { get; set; }
    }
}
