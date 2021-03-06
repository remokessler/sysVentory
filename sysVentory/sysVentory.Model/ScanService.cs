﻿using System;
using System.Collections.Generic;
using System.Linq;
using sysVentory.Model.Definitions;
using sysVentory.Model.Definitions.Types;
using sysVentory.Model.ScanServiceHelpers;

namespace sysVentory.Model
{
    public class ScanService : IScanService
    {

        private IDataBaseService _dataBaseService { get; set; }
        private IComputerService _computerService { get; set; }
        public ScanService(IDataBaseService dataBaseService = null, IComputerService computerService = null)
        {
            // IOC injection
            _dataBaseService = dataBaseService ?? new DataBaseService();
            _computerService = computerService ?? new ComputerService(dataBaseService);
        }

        /** Create a new scan and add it to a Computer */
        public IScan NewScan(string macAddress)
        {
            var data = Data.Read();
            var scan = new Scan();
            if (data == null || data.Count() <= 0)
                throw null;

            var groups = new List<IScanInformationGroup>();
            foreach (var item in data)
            {
                var scanInformationGroup = new ScanInformationGroup
                {
                    Type = item.Type,
                    Properties = item.Properties
                };
                groups.Add(scanInformationGroup);
            }
            scan.ScanInformationGroup = groups;
            scan.ScanDate = DateTime.Now;
            if(_computerService.GetComputer(computer => computer.MacAddress == macAddress) == null)
            {
                _computerService.AddComputer(macAddress);
            }
            _dataBaseService.AddScan(scan, macAddress);
            return scan;
        }

        /** Delete a scan */
        public bool DeleteScan(string macAddresse, int scanId)
        {
            return _dataBaseService.DeleteScan(macAddresse, scanId);
        }
    }
}
