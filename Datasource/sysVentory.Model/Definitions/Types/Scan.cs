using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using sysVentory.Model.Definitions.Types.Deserializer;

namespace sysVentory.Model.Definitions.Types
{
    internal class Scan : IScan
    {
        public int Id { get; set; }
        public DateTime ScanDate { get; set; }

        [JsonConverter(typeof(ScanInformationGroupConverter))]
        public IEnumerable<IScanInformationGroup> ScanInformationGroup { get; set; }
    }
}
