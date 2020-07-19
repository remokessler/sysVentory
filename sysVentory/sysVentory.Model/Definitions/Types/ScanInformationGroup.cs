using Newtonsoft.Json;
using System.Collections.Generic;
using sysVentory.Model.Definitions.Types.Deserializer;

namespace sysVentory.Model.Definitions.Types
{
    internal class ScanInformationGroup : IScanInformationGroup
    {
        public string Type { get; set; }

        [JsonConverter(typeof(ScanInformationConverter))]
        public IEnumerable<IScanInformation> Properties { get; set; }
    }
}
