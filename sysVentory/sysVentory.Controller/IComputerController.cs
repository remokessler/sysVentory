using System;
using System.Collections.Generic;
using sysVentory.Model.Definitions;

namespace sysVentory.Controller
{
    public interface IComputerController
    {
        IScan NewScan(string macAddress);
        IComputer GetComputer(Func<IComputer, bool> condition);
        IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null);
        bool DeleteComputer(string macAddress);
        bool DeleteScan(string macAddress, int scanId);
    }
}
