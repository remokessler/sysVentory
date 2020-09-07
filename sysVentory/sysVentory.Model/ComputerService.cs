using System;
using System.Collections.Generic;
using System.Linq;
using sysVentory.Model.Definitions;
using sysVentory.Model.Definitions.Types;

namespace sysVentory.Model
{
    public class ComputerService : IComputerService
    {
        private IDataBaseService _dataBaseService;

        public ComputerService(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        /** Get a list of computers */
        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            return _dataBaseService.GetComputers(condition);
        }

        /** Get a computer */
        public IComputer GetComputer(Func<IComputer, bool> condition)
        {
            return _dataBaseService.GetComputers(condition).FirstOrDefault();
        }

        /** Add a new computer */
        public IComputer AddComputer(string macAddress)
        {
            var computer = new Computer
            {
                Name = Environment.MachineName,
                MacAddress = macAddress
            };
            return _dataBaseService.AddComputer(computer);
        }

        /** Delete a computer */
        public bool DeleteComputer(string macAddress)
        {
            return _dataBaseService.DeleteComputer(macAddress);
        }
    }
}
