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

        public IComputer AddComputer(string macAddress)
        {
            var computer = new Computer
            {
                Name = Environment.MachineName,
                MacAddress = macAddress
            };
            if (File.Exists(getPath(macAddress)))
                throw new IOException("The file which should be created already existed under the path: " + getPath(macAddress));
            File.WriteAllText(getPath(macAddress), JsonConvert.SerializeObject(computer));
            return computer;
        }

        public IComputer AddScan(IScan scan, string macAddress)
        {
            if (!File.Exists(getPath(macAddress)))
            {
                AddComputer(macAddress);
            }
            var computer = JsonConvert.DeserializeObject<Computer>(File.ReadAllText(getPath(macAddress)));
            scan.Id = computer.Scans?.Max(s => s.Id) + 1 ?? 0;
            var scans = computer.Scans?.ToList() ?? new List<IScan>();
            scans.Add(scan);
            computer.Scans = scans;
            File.WriteAllText(getPath(macAddress), JsonConvert.SerializeObject(computer));
            return computer;
        }

        public IEnumerable<IComputer> GetComputers(Func<IComputer, bool> condition = null)
        {
            return Directory.GetFiles(_basePath)
                .Select(n => JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(_basePath, n))) as IComputer)
                .Where(s => condition == null ? true : condition(s));
        }

        public bool DeleteComputer(string macAddress)
        {
            if (string.IsNullOrWhiteSpace(macAddress))
                return false;

            try
            {
                File.Delete(_basePath + macAddress + file_ending);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string getPath(string macAddress)
        {
            return Path.Combine(_basePath, macAddress + file_ending);
        }
    }
}
