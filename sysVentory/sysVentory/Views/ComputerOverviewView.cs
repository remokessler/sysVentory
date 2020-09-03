using MaterialSkin;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using sysVentory.Controller;
using sysVentory.Events;
using sysVentory.Helper;

namespace sysVentory.Views
{
    internal partial class ComputerOverviewView : Form
    {
        private IComputerController _computerController { get; set; }
        private IClientConfig _clientConfig { get; set; }

        public ComputerOverviewView(IComputerController computerController = null, IClientConfig clientConfig = null)
        {
            InitializeComponent();

            _computerController = computerController ?? new ComputerController();
            _clientConfig = clientConfig ?? new ClientConfig();

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

            LstComputers.Items.AddRange(_computerController.GetComputers().Select(c => new ListViewItem(c.Name, c.MacAddress)).ToArray());
        }

        private void LstComputers_SelectedComputerChanged(object sender, EventArgs e)
        {
            if (LstComputers.SelectedItems == null || LstComputers.SelectedItems.Count <= 0)
                return;

            var computer = _computerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[0].ImageKey);
            EventHelper.Instance.EmitSelectedComputerChanged(sender, new SelectedComputerChangedEventArgs(computer));
        }

        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            var scan = _computerController.NewScan(_clientConfig.MacAddress);
            if (scan != null)
            {
                MessageBox.Show("Scan successfully done");
            }
            else
            {
                MessageBox.Show("An Error occured while scanning!");
            }

            EventHelper.Instance.EmitNewScan(sender, new NewScanEventArgs(scan));
        }

        private void CmdDeleteComputer_Click(object sender, EventArgs e)
        {
            if (_computerController.DeleteComputer(LstComputers.SelectedItems[0].ImageKey))
            {
                MessageBox.Show("Computer successfully deleted");
                LoadComputers();
                EventHelper.Instance.EmitSelectedComputerChanged(sender, new SelectedComputerChangedEventArgs(null));
            }

            else
            {
                MessageBox.Show("An Error occured while deleting!");
            }
        }

        private void CmdCompareComputer_Click(object sender, EventArgs e)
        {
            if (LstComputers.SelectedItems?.Count != 2)
            {
                MessageBox.Show("Please select exactly 2 computers to compare. You can multiselect by holding CTRL.");
                return;
            }
            var computerLeft = _computerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[0].ImageKey);
            var computerRight = _computerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[1].ImageKey);
            if (computerLeft?.Scans?.Count() > 0 && computerRight?.Scans?.Count() > 0)
            {
                var form = new ScanCompareView(
                    computerLeft.Scans.OrderByDescending(s => s.ScanDate).First(), 
                    computerRight.Scans.OrderByDescending(s => s.ScanDate).First(),
                    computerLeft.Name,
                    computerRight.Name);

                form.Owner = this;
                form.ShowInTaskbar = false;
                form.ShowDialog();
            }
        }
    }
}
