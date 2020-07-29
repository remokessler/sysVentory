using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Helper;

namespace sysVentory.Views
{
    public partial class ScanedComputers : Form
    {
        public string ActiveComputer { get; private set; }
        public ScanedComputers()
        {
            InitializeComponent();
            string[] computerNames = ControllerHelper.Instance.ComputerController.GetComputers().Select(c => c.Name).ToArray();
            LstComputerNames.Items.AddRange(computerNames);
        }

        private void LstComputerNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ActiveComputer = Convert.ToString(LstComputerNames.SelectedItem);
        }
    }
}
