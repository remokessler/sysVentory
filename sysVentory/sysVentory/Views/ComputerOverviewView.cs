using System;
using System.Linq;
using System.Windows.Forms;
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

        /** Event consumer reloads all computers when a new scan is added */
        private void OnNewScan(object sender, NewScanEventArgs e)
        {
            LoadComputers();
        }

        /** Loads all Computers and adds them to the LstComputers */
        private void LoadComputers()
        {
            if (LstComputers.Items.Count > 0)
                LstComputers.Items.Clear();

            LstComputers.Items.AddRange(_computerController.GetComputers().Select(c => new ListViewItem(c.Name, c.MacAddress)).ToArray());
        }

        /** Event if selected Computer is changed */
        private void LstComputers_SelectedComputerChanged(object sender, EventArgs e)
        {
            if (LstComputers.SelectedItems == null || LstComputers.SelectedItems.Count <= 0)
                return;

            var computer = _computerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[0].ImageKey);
            EventHelper.Instance.EmitSelectedComputerChanged(sender, new SelectedComputerChangedEventArgs(computer));
        }

        /** Click on add new Scan event */
        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            var scan = _computerController.NewScan(_clientConfig.Uuid);
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

        /** Click on delete computer event */
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

        /** Button open the latest scans on the selected computers */
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
