using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;
using sysVentory.Services;

namespace sysVentory
{
    public partial class ScanDetailsView : Form
    {
        public ScanDetailsView(IScan scan, string computerName, ITreeService treeService = null)
        {
            InitializeComponent();

            // IOC injection
            treeService = treeService ?? new TreeService();

            TreScan.Nodes.Clear();
            LblScanTitle.Text = $"Computer: {computerName ?? string.Empty} | Scan: {scan.Id.ToString()} from {scan.ScanDate.ToString("dd-MM-yyyy HH:mm")}";
            treeService.BuildTree(TreScan, scan);
        }

        /** Button close */
        private void CmdClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
