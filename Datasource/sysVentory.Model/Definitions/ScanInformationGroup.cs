using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    internal class ScanInformationGroup : IScanInformationGroup
    {
        public string Type { get; set; }
        public IEnumerable<IScanInformation> Properties { get; set; }
    }
}
