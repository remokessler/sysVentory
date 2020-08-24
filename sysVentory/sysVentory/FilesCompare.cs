using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class FilesCompare : Form
    {
        public FilesCompare(IScan leftScan, IScan rightScan)
        {
            InitializeComponent();
            TreFile1.Nodes.Clear();
            TreFile2.Nodes.Clear();
            LblFile1.Text = leftScan.ScanDate.ToString("dd-MM-yyyy HH:mm");
            LblFile2.Text = rightScan.ScanDate.ToString("dd-MM-yyyy HH:mm");
            PleaseGetHelp(TreFile1, leftScan);
            PleaseGetHelp(TreFile2, rightScan);
        }

        public void PleaseGetHelp(TreeView tv, IScan scan)
        {
            foreach (IScanInformationGroup sig in scan.ScanInformationGroup)
            {
                var treeNode = new TreeNode(sig.ToString());
                foreach (IScanInformation si in sig.Properties)
                {
                    treeNode.Nodes.Add(si.ToString());
                }
                tv.Nodes.Add(treeNode);
            }
        }
        // TreeView1.SelectedNode.BackColor = SystemColors.HighlightText; -> highlighting elements
    }
}
