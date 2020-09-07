using System;
using System.Windows.Forms;
using sysVentory.Views;

namespace sysVentory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pnlScanedComputers.Dock = DockStyle.Top | DockStyle.Left | DockStyle.Bottom;
            LoadComputersForm(new ComputerOverviewView());
            LoadScansForm(new ScanOverviewView());
        }

        private void LoadComputersForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanedComputers.Controls.Add(form);
            form.Show();
        }

        private void LoadScansForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanHistroy.Controls.Add(form);
            form.Show();
        }
    }
}
