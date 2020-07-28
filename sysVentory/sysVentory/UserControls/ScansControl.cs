using System;
using System.Linq;
using System.Windows.Forms;
using sysVentory.Controller;

namespace sysVentory
{
    public partial class ScansControl : UserControl
    {
        //private IComputerController _computerController { get; set; }
        public ScansControl()//IComputerController computerController)
        {
            InitializeComponent();
            //_computerController = computerController;
            LoadData();
        }
        //public ScansControl() : this(new ComputerController()) { }
        private void CmdNewScan_Click(object sender, EventArgs e)
        {
            //NewScan();
        }
        private void NewScan()
        {
            //_computerController.NewScan(MacAddressService.Instance.GetCurrent);
        }
        private void LoadData()
        {
            //string[] test = LoadScans.Instance.List;
            //LstScans.Items.AddRange(test);
            LstScans.Items.AddRange(LoadScans.Instance.List);
        }
    }
}
