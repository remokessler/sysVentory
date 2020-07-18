using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    public interface IDataBaseService
    {
        IComputer AddComputer(string macAddress);
        IComputer AddScan(IScan scan, string macAddress);
        IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null);
        bool DeleteComputer(string macAddress);
    }
}
