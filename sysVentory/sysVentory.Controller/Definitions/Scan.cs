using System;
using System.Collections.Generic;
using sysVentory.Model.Definitions;

namespace sysVentory.Controller.Definitions
{
    public class Scan : IScan
    {
        public int Id { get; set; }
        public DateTime ScanDate { get; set; }
        public IEnumerable<IScanInformationGroup> ScanInformationGroup { get; set; }
    }
}
