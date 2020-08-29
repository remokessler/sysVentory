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
        }

        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            var scan = ControllerHelper.Instance.ComputerController.NewScan(MacAddressHelper.Instance.Current);
            MessageBox.Show("Scan successfully done", "Done");

            EventHelper.Instance.EmitNewScan(sender, new NewScanEventArgs());
            LstScans.Items.Add(new ListViewItem(scan.ScanDate.ToString(), scan.Id));
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            if (LstScans.SelectedItems?.Count != 2)
            {
                MessageBox.Show("Please select exactly 2 Scans. You can select multiple with holding CTRL.");
                return;
            }
            var scanLeft = _selectedComputer.Scans.First(s => s.Id == LstScans.SelectedItems[0].Index);
            var scanRight = _selectedComputer.Scans.First(s => s.Id == LstScans.SelectedItems[1].Index);

            Form form = new FilesCompare(scanLeft, scanRight);
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
            LstScans.Items.AddRange(_selectedComputer.Scans.Select(s => new ListViewItem(s.ScanDate.ToString(), s.Id)).ToArray());
        }
    }
}
