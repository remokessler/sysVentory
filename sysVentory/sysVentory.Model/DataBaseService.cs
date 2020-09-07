using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using sysVentory.Model.Definitions;
using sysVentory.Model.Definitions.Types;

namespace sysVentory.Model
{
    public class DataBaseService : IDataBaseService
    {
        private const string file_ending = ".json";
        private string _basePath => Path.Combine(AppContext.BaseDirectory, "data");

        public DataBaseService()
        {
            Directory.CreateDirectory(_basePath);
        }

        /** Add a computer and write it to the json File */
        public IComputer AddComputer(IComputer computer)
        {
            if (computer.MacAddress == null)
            {
                throw new ArgumentException();
            }
            if (File.Exists(GetPath(computer.MacAddress)))
            {
                throw new IOException("The file which should be created already existed under the path: " + GetPath(computer.MacAddress));
            }

            File.WriteAllText(GetPath(computer.MacAddress), JsonConvert.SerializeObject(computer));
            return computer;
        }

        /** Add a scan to a computer and write it to the json file */
        public IComputer AddScan(IScan scan, string macAddress)
        {
            if (!File.Exists(GetPath(macAddress)))
            {
                throw new ArgumentException("MAC Adress: " + macAddress + "is not yet saved!");
            }
            var computer = JsonConvert.DeserializeObject<Computer>(File.ReadAllText(GetPath(macAddress)));

            if (computer.Scans?.Count() == 0)
                scan.Id = 0;
            else
                scan.Id = computer.Scans?.Max(s => s.Id) + 1 ?? 0;

            var scans = computer.Scans?.ToList() ?? new List<IScan>();
            scans.Add(scan);
            computer.Scans = scans;
            File.WriteAllText(GetPath(macAddress), JsonConvert.SerializeObject(computer));
            return computer;
        }

        /** Get Computers from file */
        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            try
            {
                return Directory.GetFiles(_basePath)
                .Select(n => JsonConvert.DeserializeObject<Computer>(File.ReadAllText(Path.Combine(_basePath, n))))
                .Where(s => condition == null ? true : condition(s));
            }
            catch (IOException)
            {
                return null;
            }
        }

        /** Delete a computer */
        public bool DeleteComputer(string macAddress)
        {
            if (string.IsNullOrWhiteSpace(macAddress))
            {
                return false;
            }

            try
            {
                File.Delete(GetPath(macAddress));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /** Delete a Scan */
        public bool DeleteScan(string macAddress, int scanId)
        {
            if (string.IsNullOrWhiteSpace(macAddress) || scanId < 0)
            {
                return false;
            }

            try
            {
                var computer = JsonConvert.DeserializeObject<Computer>(File.ReadAllText(GetPath(macAddress)));
                var scans = computer.Scans.ToList();
                scans.Remove(computer.Scans.First(s => s.Id == scanId));
                computer.Scans = scans;
                File.WriteAllText(GetPath(computer.MacAddress), JsonConvert.SerializeObject(computer));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /* combines the Path to a file */
        private string GetPath(string macAddress)
        {
            return Path.Combine(_basePath, macAddress + file_ending);
        }
    }
}
