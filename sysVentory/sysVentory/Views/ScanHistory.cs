using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            MessageBox.Show("Scan successfully done", "Done");
            //TODO Update List
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            Form form = new FilesCompare();
            form.Owner = this;
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }
    }
}
