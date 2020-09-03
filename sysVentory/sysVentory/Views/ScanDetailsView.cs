using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class ScanDetailsView : Form
    {
        public ScanDetailsView(IScan scan, string computerName)
        {
            InitializeComponent();
            TreScan.Nodes.Clear();
            LblScanTitle.Text = $"Computer: {computerName ?? string.Empty} | Scan: {scan.Id.ToString()} from {scan.ScanDate.ToString("dd-MM-yyyy HH:mm")}";
            BuildTree(TreScan, scan);
        }

        public void BuildTree(TreeView tv, IScan scan)
        {
            foreach (IScanInformationGroup sig in scan.ScanInformationGroup.OrderBy(g => g.Type))
            {
                var treeNode = new TreeNode(sig.ToString());
                treeNode.ForeColor = Color.White;
                treeNode.Expand();
                var propertiesSorted = sig.Properties.OrderBy(p => p.Name).ToList();
                foreach (IScanInformation si in propertiesSorted)
                {
                    var childNode = new TreeNode(si.ToString());
                    childNode.ForeColor = Color.White;
                    treeNode.Nodes.Add(childNode);
                }
                tv.Nodes.Add(treeNode);
            }
        }

        private void CmdClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
