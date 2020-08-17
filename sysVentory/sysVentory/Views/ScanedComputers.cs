using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Events;
using sysVentory.Helper;
using sysVentory.Model.Definitions;

namespace sysVentory.Views
{
    public partial class ScanedComputers : Form
    {
        public ScanedComputers()
        {
            InitializeComponent();
            LoadComputers();
        }
        
        private void LoadComputers()
        {
            if (LstComputers.Items.Count > 0)
                LstComputers.Items.Clear();

            LstComputers.Items.AddRange(ControllerHelper.Instance.ComputerController
                                    .GetComputers().Select(c => new ListViewItem(c.Name, c.MacAddress)).ToArray());
        }

        private void LstComputers_SelectedComputerChanged(object sender, EventArgs e)
        {
            if (LstComputers.SelectedItems == null || LstComputers.SelectedItems.Count <= 0)
                return;

            var computer = ControllerHelper.Instance.ComputerController.GetComputer(c => c.MacAddress == LstComputers.SelectedItems[0].ImageKey);
            EventHelper.Instance.EmitSelectedComputerChanged(computer, new SelectedComputerChangedEventArgs());
        }
    }
}
