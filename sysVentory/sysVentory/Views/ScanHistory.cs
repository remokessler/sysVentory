using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using sysVentory.Events;
using sysVentory.Helper;
using sysVentory.Model.Definitions;

namespace sysVentory.Views
{
    public partial class ScanHistory : Form
    {

        public ScanHistory()
        {
            InitializeComponent();
            EventHelper.Instance.OnSelectedComputerChanged += SelectedComputerChanged;
        }

        public void CmdNewScan_Click(object sender, EventArgs e)
        {
            ControllerHelper.Instance.ComputerController.NewScan(MacAddressHelper.Instance.Current);
            MessageBox.Show("Scan successfully done", "Done");

            EventHelper.Instance.EmitNewScan(sender, new NewScanEventArgs());
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            var scan = sender as IScan;

            Form form = new FilesCompare(scan, scan);
            form.Owner = this;
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }

        private void SelectedComputerChanged(object sender, SelectedComputerChangedEventArgs sccea)
        {
            LstScans.Items.Clear();
            var computer = sender as IComputer;
            LstScans.Items.AddRange(computer.Scans.Select(s => new ListViewItem(s.ScanDate.ToString(), s.Id)).ToArray());
        }
    }
}
