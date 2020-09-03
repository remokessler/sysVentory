using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Controller;
using sysVentory.Events;
using sysVentory.Helper;
using sysVentory.Model.Definitions;

namespace sysVentory.Views
{
    internal partial class ScanOverviewView : Form
    {
        private IComputer _selectedComputer { get; set; }
        private IComputerController _computerController { get; set; }
        private IClientConfig _clientConifg { get; set; }

        public ScanOverviewView(IComputerController computerController = null, IClientConfig clientConfig = null)
        {
            InitializeComponent();

            _computerController = computerController ?? new ComputerController();
            _clientConifg = clientConfig ?? new ClientConfig();

            EventHelper.Instance.OnSelectedComputerChanged += SelectedComputerChanged;
            EventHelper.Instance.OnNewScan += NewScan;
        }

        private void NewScan(object sender, NewScanEventArgs e)
        {
            var scan = e.NewScan;
            if (_selectedComputer != null && _selectedComputer.MacAddress == _clientConifg.MacAddress)
            {
                LstScans.Items.Add(new ListViewItem(scan.ScanDate.ToString(), scan.Id));
                _selectedComputer = _computerController.GetComputer(c => c.MacAddress == _selectedComputer.MacAddress);
            }
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            if (LstScans.SelectedItems?.Count != 2)
            {
                MessageBox.Show("Please select exactly 2 Scans. You can select multiple with holding CTRL.");
                return;
            }
            var scanLeft = _selectedComputer.Scans.First(s => s.Id == LstScans.SelectedItems[0].ImageIndex);
            var scanRight = _selectedComputer.Scans.First(s => s.Id == LstScans.SelectedItems[1].ImageIndex);

            var scanCompareView = new ScanCompareView(scanLeft, scanRight, _selectedComputer.Name, _selectedComputer.Name);
            scanCompareView.Owner = this;
            scanCompareView.ShowInTaskbar = false;
            scanCompareView.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in LstScans.SelectedItems)
            {
                if (_computerController.DeleteScan(_clientConifg.MacAddress, lvi.ImageIndex))
                {
                    LstScans.Items.Remove(lvi);
                }
            }
        }

        private void SelectedComputerChanged(object sender, SelectedComputerChangedEventArgs sccea)
        {
            LstScans.Items.Clear();
            _selectedComputer = sccea.NewSelectedComputer;
            LblActiveComputer.Text = _selectedComputer.Name ?? string.Empty;
            if (_selectedComputer != null)
            {
                LstScans.Items.AddRange(_selectedComputer.Scans.Select(s => new ListViewItem(s.ScanDate.ToString(), s.Id)).ToArray());
            }
        }

        private void CmdDetails_Click(object sender, EventArgs e)
        {
            if (LstScans.SelectedItems?.Count != 1)
            {
                MessageBox.Show("Please select exactly 1 Scan.");
                return;
            }
            var scanLeft = _selectedComputer.Scans.First(s => s.Id == LstScans.SelectedItems[0].ImageIndex);

            var scanDetails = new ScanDetailsView(scanLeft, _selectedComputer.Name);
            scanDetails.Owner = this;
            scanDetails.ShowInTaskbar = false;
            scanDetails.ShowDialog();
        }
    }
}
