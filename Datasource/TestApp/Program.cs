using System;
using System.Linq;
using System.Net.NetworkInformation;
using sysVentory.Model;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScanService serv = new ScanService(new DataBaseService());
            Console.WriteLine(serv.NewScan(_currentMacAddress));
            Console.ReadLine();
        }
        private static string _currentMacAddress => NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
    }
}
