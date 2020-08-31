using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Events;
using sysVentory.Helper;

namespace sysVentory.Views
{
    public partial class ScanedComputers : Form
    {
        public ScanedComputers()
        {
            InitializeComponent();
            LoadComputers();
            EventHelper.Instance.OnNewScan += OnNewScan;
        }

        private void OnNewScan(object sender, NewScanEventArgs e)
        {
            LoadComputers();
        }

        private void LoadComputers()
        {
            if (LstComputers.Items.Count > 0)
                LstComputers.Items.Clear();

            LstComputers.Items.AddRange(ControllerHelper.Instance.ComputerController
                                    .GetComputers().Select(c => new ListViewItem(c.Name, c.MacAddress)).ToArray());
        }

        private void LstComputers_SelectedComputerChanged(object sender, EventArgs e)
        {
            if (LstComputers.SelectedItems == null || LstComputers.SelectedItems.Count <= 0)
                return;

            var computer = ControllerHelper.Instance.ComputerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[0].ImageKey);
            EventHelper.Instance.EmitSelectedComputerChanged(computer, new SelectedComputerChangedEventArgs());
        }

        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            var scan = ControllerHelper.Instance.ComputerController.NewScan(MacAddressHelper.Instance.Current);
            MessageBox.Show("Scan successfully done");

            EventHelper.Instance.EmitNewScan(sender, new NewScanEventArgs(scan));
        }

        private void CmdDeleteComputer_Click(object sender, EventArgs e)
        {
            if (ControllerHelper.Instance.ComputerController.DeleteComputer(LstComputers.SelectedItems[0].ImageKey))
            {
                MessageBox.Show("Computer successfully deleted");
                LoadComputers();
                EventHelper.Instance.EmitSelectedComputerChanged(null, new SelectedComputerChangedEventArgs());
            }
        }
    }
}
