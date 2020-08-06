using System.Linq;
using System.Net.NetworkInformation;

namespace sysVentory
{
    internal class MacAddressHelper
    {
        public static MacAddressHelper Instance => _instance = _instance ?? new MacAddressHelper();
        public string Current { get; private set; }
        private static MacAddressHelper _instance { get; set; }

        private MacAddressHelper()
        {
            Current = NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
        }
    }
}
