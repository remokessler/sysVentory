using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class ScanDetails : Form
    {
        public ScanDetails(IScan scan)
        {
            InitializeComponent();
            TreScan.Nodes.Clear();
            LblScan.Text = scan.Id.ToString() + ": " + scan.ScanDate.ToString("dd-MM-yyyy HH:mm");
            BuildSourceTree(TreScan, scan);
        }

        public void BuildSourceTree(TreeView tv, IScan scan)
        {
            foreach (IScanInformationGroup sig in scan.ScanInformationGroup.OrderBy(g => g.Type))
            {
                var treeNode = CreateGroupNode(sig);
                foreach (IScanInformation si in sig.Properties)
                {
                    var childNode = new TreeNode(si.ToString());
                    childNode.ForeColor = Color.White;
                    treeNode.Nodes.Add(childNode);
                }
                tv.Nodes.Add(treeNode);
            }
        }

        private TreeNode CreateGroupNode(IScanInformationGroup sig)
        {
            var treeNode = new TreeNode(sig.ToString());
            treeNode.ForeColor = Color.White;
            treeNode.Expand();
            return treeNode;
        }
    }
}
