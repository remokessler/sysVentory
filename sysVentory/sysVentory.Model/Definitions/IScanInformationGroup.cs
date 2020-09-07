using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    // Abstraction of ScanInformationGroup
    public interface IScanInformationGroup
    {
        string Type { get; set; }
        IEnumerable<IScanInformation> Properties { get; set; }
    }
}
