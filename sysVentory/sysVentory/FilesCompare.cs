using System;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class FilesCompare : Form
    {
        public FilesCompare(IScan leftScan, IScan rightScan)
        {
            InitializeComponent();
            LblFile1.Text = "...";
            LblFile2.Text = "...";
            TreFile1.Nodes.Clear();
            TreFile2.Nodes.Clear();
            LblFile1.Text = leftScan.ScanDate.ToString("dd-MM-yyyyy HH:mm");
            if(rightScan != null)
            {
                LblFile2.Text = rightScan.ScanDate.ToString("dd-MM-yyyyy HH:mm");
            }
        }

        // TreeView1.SelectedNode.BackColor = SystemColors.HighlightText; -> highlighting elements
    }
}
