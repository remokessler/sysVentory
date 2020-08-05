using System;
using System.Windows.Forms;
using sysVentory.Helper;

namespace sysVentory.Views
{
    public partial class ScanHistory : Form
    {
        public ScanHistory()
        {
            InitializeComponent();
        }

        public void cmdNewScan_Click(object sender, EventArgs e)
        {
            ControllerHelper.Instance.ComputerController.NewScan(MacAddressHelper.Instance.Current);
            //TODO interface between the two Views
            lstScanHistroy.Items.AddRange(new UpdateLstHelper().computerNames);
            MessageBox.Show("Scan successfully done", "Success");
        }
    }
}
