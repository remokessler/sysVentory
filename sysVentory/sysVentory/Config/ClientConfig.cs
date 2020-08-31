using System.Linq;
using System.Net.NetworkInformation;
using sysVentory.Helper;

namespace sysVentory
{
    internal class ClientConfig : IClientConfig
    {
        public string MacAddress { get; private set; }

        public ClientConfig()
        {
            MacAddress = NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
        }
    }
}
