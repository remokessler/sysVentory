using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    internal class Computer : IComputer
    {
        public string Name { get; set; }
        public string MacAddress { get; set; }
        public IEnumerable<IScan> Scans { get; set; }
    }
}
