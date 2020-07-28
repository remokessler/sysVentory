using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Controller;

namespace sysVentory
{
    public partial class ScansControl : UserControl
    {
        private IComputerController _computerController { get; set; }
        public ScansControl(IComputerController computerController = null)
        {
            InitializeComponent();
            _computerController = computerController ?? new ComputerController();
            LoadData();
        }

        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            _computerController.NewScan(MacAddressHelper.Instance.Current);
        }
        private async void LoadData()
        {
            //string[] computerNames = _computerController.GetComputers().Select(c => c.name);
            //LstScans.Items.AddRange(computerNames);
        }
    }
}
