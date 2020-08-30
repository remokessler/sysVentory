using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Events;
using sysVentory.Helper;
using sysVentory.Model.Definitions;

namespace sysVentory.Views
{
    public partial class ScanHistory : Form
    {
        private IComputer _selectedComputer { get; set; }

        public ScanHistory()
        {
            InitializeComponent();
            EventHelper.Instance.OnSelectedComputerChanged += SelectedComputerChanged;
            EventHelper.Instance.OnNewScan += NewScan;
        }

        private void NewScan(object sender, NewScanEventArgs e)
        {
            var scan = e.NewScan;
            if (_selectedComputer != null && _selectedComputer.MacAddress == MacAddressHelper.Instance.Current)
            {
                LstScans.Items.Add(new ListViewItem(scan.ScanDate.ToString(), scan.Id));
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

            var form = new FilesCompare(scanLeft, scanRight);
            form.Owner = this;
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in LstScans.SelectedItems)
            {
                if (ControllerHelper.Instance.ComputerController.DeleteScan(MacAddressHelper.Instance.Current, lvi.ImageIndex))
                {
                    LstScans.Items.Remove(lvi);
                }
            }
        }

        private void SelectedComputerChanged(object sender, SelectedComputerChangedEventArgs sccea)
        {
            LstScans.Items.Clear();
            _selectedComputer = sender as IComputer;
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

            var form = new ScanDetails(scanLeft);
            form.Owner = this;
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }
    }
}
