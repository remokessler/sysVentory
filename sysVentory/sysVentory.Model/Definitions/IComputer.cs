using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    // Abstraction of Computer
    public interface IComputer
    {
        string Name { get; set; }
        string MacAddress { get; set; }
        IEnumerable<IScan> Scans { get; set; }
    }
}
