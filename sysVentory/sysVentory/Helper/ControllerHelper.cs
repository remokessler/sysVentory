using sysVentory.Controller;

namespace sysVentory.Helper
{
    internal class ControllerHelper
    {
        public static ControllerHelper Instance => _instance = _instance ?? new ControllerHelper();
        public IComputerController ComputerController { get; private set; }
        private static ControllerHelper _instance { get; set; }

        private ControllerHelper(IComputerController computerController = null)
        {
            ComputerController = computerController ?? new ComputerController();
        }
    }
}
