using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    public interface IComputerService
    {
        IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null);
        IComputer GetComputer(Func<IComputer, bool> condition);
        bool DeleteComputer(string macAddress);
    }
}
