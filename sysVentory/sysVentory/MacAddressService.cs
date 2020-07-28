using System.Linq;
using System.Net.NetworkInformation;

namespace sysVentory
{
    internal class MacAddressService
    {
        public static MacAddressService Instance => _instance = _instance ?? new MacAddressService();
        public string GetCurrent { get; private set; }
        private static MacAddressService _instance { get; set; }

        private MacAddressService()
        {
            GetCurrent = NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
        }
    }
}
