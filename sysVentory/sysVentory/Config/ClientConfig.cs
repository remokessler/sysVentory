using System.Management;
using sysVentory.Helper;

namespace sysVentory
{
    internal class ClientConfig : IClientConfig
    {
        /*=================================================================*/
        /*ClientConfig.cs reads the UUID of the Computer for the .json File*/
        /*=================================================================*/
        public string Uuid { get; private set; }

        public ClientConfig()
        {
            string ComputerName = "localhost";
            ManagementScope Scope;
            Scope = new ManagementScope(string.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);
            Scope.Connect();
            ObjectQuery Query = new ObjectQuery("SELECT UUID FROM Win32_ComputerSystemProduct");
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);
            foreach (ManagementObject WmiObject in Searcher.Get())
            {
                Uuid = WmiObject["UUID"].ToString();
            }
        }
    }
}
