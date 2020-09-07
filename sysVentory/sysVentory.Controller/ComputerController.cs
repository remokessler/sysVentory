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

        public ComputerController(IScanService scanService = null, IComputerService computerService = null,  IDataBaseService dataBaseService = null)
        {
            // IOC injection
            dataBaseService = dataBaseService ?? new DataBaseService();
            _computerService = computerService ?? new ComputerService(dataBaseService);
            _scanService = scanService ?? new ScanService(dataBaseService, _computerService);
        }

        /** Add a new scan */
        public IScan NewScan(string macAddress)
        {
            return _scanService.NewScan(macAddress);
        }

        /** Get a computer */
        public IComputer GetComputer(Func<IComputer, bool> condition)
        {
            return _computerService.GetComputer(condition);
        }

        /** Get a List of computers */
        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            return _computerService.GetComputers(condition);
        }

        /** Delete a computer */
        public bool DeleteComputer(string macAddress)
        {
            return _computerService.DeleteComputer(macAddress);
        }

        /** Delete a scan */
        public bool DeleteScan(string macAddress, int scanId)
        {
            return _scanService.DeleteScan(macAddress, scanId);
        }
    }
}
