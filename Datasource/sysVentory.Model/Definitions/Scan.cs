using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    internal class Scan : IScan
    {
        public int Id { get; set; }
        public DateTime ScanDate { get; set; }
        public IEnumerable<IScanInformationGroup> ScanInformationGroup { get; set; }
    }
}
