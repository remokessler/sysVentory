using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    public interface IComputer
    {
        string Name { get; set; }
        string MacAddress { get; set; }
        IEnumerable<IScan> Scans { get; set; }
    }
}
