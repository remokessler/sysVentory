using System.Linq;
using sysVentory.Controller;

namespace sysVentory
{
    internal class LoadScans
    {
        public static LoadScans Instance => _instance = _instance ?? new LoadScans();
        public string[] List { get; private set; }
        private static LoadScans _instance { get; set; }
        private IComputerController _computerController { get; set; }
        public LoadScans(IComputerController computerController = null)
        {
            _computerController = computerController ?? new ComputerController();
            List = _computerController.GetComputers().Select(c => c.Name).ToArray();
        }
    }
}
