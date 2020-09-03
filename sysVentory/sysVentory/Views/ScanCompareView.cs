using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Model.Definitions;

namespace sysVentory
{
    public partial class ScanCompareView : Form
    {
        public ScanCompareView(IScan leftScan, IScan rightScan, string computerNameLeft, string computerNameRight)
        {
            InitializeComponent();
            TreLeft.Nodes.Clear();
            TreRight.Nodes.Clear();
            LblScanTitleLeft.Text = $"Computer: {computerNameLeft ?? string.Empty} | Scan: {leftScan.Id.ToString()} from {leftScan.ScanDate.ToString("dd-MM-yyyy HH:mm")}";
            LblScanTitleRight.Text = $"Computer: {computerNameRight ?? string.Empty} | Scan: {rightScan.Id.ToString()} from {rightScan.ScanDate.ToString("dd-MM-yyyy HH:mm")}";
            BuildSourceTree(TreLeft, leftScan);
            BuildCompareTree(TreRight, leftScan, rightScan);
        }

        public void BuildSourceTree(TreeView tv, IScan scan)
        {
            foreach (IScanInformationGroup sig in scan.ScanInformationGroup.OrderBy(g => g.Type))
            {
                var treeNode = CreateGroupNode(sig);
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

        public void BuildCompareTree(TreeView tv, IScan source, IScan compare)
        {
            var groupsOfSameType = 0;
            var lastType = string.Empty;
            foreach (IScanInformationGroup sig in compare.ScanInformationGroup.OrderBy(g => g.Type))
            {
                var treeNode = CreateGroupNode(sig);

                groupsOfSameType = lastType == sig.Type ? groupsOfSameType + 1 : 0;
                lastType = sig.Type;
                
                var correspondingSoureGroup = source.ScanInformationGroup
                    .Where(g => g.Type == sig.Type).ElementAtOrDefault(groupsOfSameType);

                var removedProperties = correspondingSoureGroup?.Properties
                    .Where(p => !sig.Properties.Any(sp => sp.Name == p.Name));

                var mergedSourceAndCompareProperties = new List<IScanInformation>(sig.Properties);
                if (removedProperties != null)
                {
                    mergedSourceAndCompareProperties.AddRange(removedProperties);
                }

                foreach (IScanInformation si in mergedSourceAndCompareProperties.OrderBy(p => p.Name))
                {
                    var childNode = new TreeNode(si.ToString());
                    childNode.ForeColor = GetColorForProperty(removedProperties, correspondingSoureGroup, si); ;
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

        private Color GetColorForProperty(IEnumerable<IScanInformation> removedProperties, IScanInformationGroup correspondingSoureGroup, IScanInformation currentScanInformation)
        {
            // if the property has been removed
            if (removedProperties?.Any(p => p.Name == currentScanInformation.Name) == true)
                return Color.Red;

            // if the property is not changed
            else if (correspondingSoureGroup?.Properties
                .Any(p => p.Name == currentScanInformation.Name 
                    && p.Value?.ToString() == currentScanInformation.Value?.ToString()) == true)
                return Color.White;

            // if the property is changed
            else if (correspondingSoureGroup?.Properties
                .Any(p => p.Name == currentScanInformation.Name 
                    && p.Value?.ToString() != currentScanInformation.Value?.ToString()) == true)
                return Color.Orange;

            // Property is newly added
            return Color.Green;
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
