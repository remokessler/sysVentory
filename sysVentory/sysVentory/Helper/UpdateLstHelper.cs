using System.Linq;

namespace sysVentory.Helper
{
    internal class UpdateLstHelper
    {
        public string[] computerNames { get; private set; }
        public string[] fileNames { get; private set; }
        public UpdateLstHelper()
        {
            computerNames = ControllerHelper.Instance.ComputerController.GetComputers().Select(c => c.Name).ToArray();
            //TODO update FileNames
            fileNames
        }
    }
}
