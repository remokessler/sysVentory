using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    public interface IScanInformationGroup
    {
        string Type { get; set; }
        IEnumerable<IScanInformation> Properties { get; set; }
    }
}
