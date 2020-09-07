using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory.Services
{
    public class TreeService : ITreeService
    {
        /** Build Treeview*/
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
    }
}
