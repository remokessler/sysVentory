﻿using System;
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

        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            return _dataBaseService.GetComputers(condition);
        }

        public IComputer GetComputer(Func<IComputer, bool> condition)
        {
            return _dataBaseService.GetComputers(condition).FirstOrDefault();
        }

        public IComputer AddComputer(string macAddress)
        {
            var computer = new Computer
            {
                Name = Environment.MachineName,
                MacAddress = macAddress
            };
            return _dataBaseService.AddComputer(computer);
        }

        public bool DeleteComputer(string macAddress)
        {
            return _dataBaseService.DeleteComputer(macAddress);
        }
    }
}
