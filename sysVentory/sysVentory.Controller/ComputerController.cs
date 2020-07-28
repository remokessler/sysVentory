using System;
using System.Collections.Generic;
using sysVentory.Model;
using sysVentory.Model.Definitions;

namespace sysVentory.Controller
{
    public class ComputerController : IComputerController
    {
        private IScanService _scanService { get; set; }
        private IComputerService _computerService { get; set; }

        public ComputerController(IScanService scanService = null,
            IComputerService computerService = null, 
            IDataBaseService dataBaseService = null)
        {
            dataBaseService = dataBaseService ?? new DataBaseService();
            _scanService = scanService ?? new ScanService(dataBaseService);
            _computerService = computerService ?? new ComputerService(dataBaseService);
        }

        public IScan NewScan(string macAddress)
        {
            return _scanService.NewScan(macAddress);
        }

        public IComputer GetComputer(Func<IComputer, bool> condition)
        {
            return _computerService.GetComputer(condition);
        }

        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            return _computerService.GetComputers(condition);
        }
        public bool DeleteComputer(string macAddress)
        {
            return _computerService.DeleteComputer(macAddress);
        }
    }
}
