using System;
using System.Linq;
using System.Net.NetworkInformation;
using sysVentory.Controller;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var computerController = new ComputerController();
            Console.WriteLine(computerController.NewScan(_currentMacAddress));
            Console.ReadLine();
        }
        private static string _currentMacAddress => NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
    }
}
