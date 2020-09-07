using System;
using System.Collections.Generic;

namespace sysVentory.Model.Definitions
{
    // Abstraction of ComputerService
    public interface IComputerService
    {
        IComputer AddComputer(string macAddress);
        IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null);
        IComputer GetComputer(Func<IComputer, bool> condition);
        bool DeleteComputer(string macAddress);
    }
}
