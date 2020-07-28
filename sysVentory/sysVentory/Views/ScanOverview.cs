using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Helper;

namespace sysVentory.Views
{
    public partial class ScanOverview : Form
    {
        public ScanOverview()
        {
            InitializeComponent();
            ControllerHelper.Instance.ComputerController.NewScan(MacAddressHelper.Instance.Current);
            string[] computerNames = ControllerHelper.Instance.ComputerController.GetComputers().Select(c => c.Name).ToArray();
            LsbTest.Items.AddRange(computerNames);
        }
    }
}
