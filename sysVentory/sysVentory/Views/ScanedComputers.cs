using System;
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
            //TODO load list when inizialize
        }
        private void LstComputerNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ActiveComputer = Convert.ToString(LstComputerNames.SelectedItem);
        }
    }
}
