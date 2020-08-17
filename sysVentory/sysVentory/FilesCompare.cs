using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class FilesCompare : Form
    {
        public FilesCompare(IScan leftScan, IScan rightScan)
        {
            InitializeComponent();
        }

        // TreeView1.SelectedNode.BackColor = SystemColors.HighlightText; -> highlighting elements
    }
}
