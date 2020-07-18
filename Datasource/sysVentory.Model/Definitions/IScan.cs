using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    public interface IScan
    {
        int Id { get; set; }
        DateTime ScanDate { get; set; }
        IEnumerable<IScanInformationGroup> ScanInformationGroup { get; set; }
    }
}
