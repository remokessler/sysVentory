using System;
using System.Windows.Forms;
using sysVentory.Views;

namespace sysVentory
{
    public partial class Main : Form
    {
        public EventHandler SelectedComputerChangedHandler { get; set; }
        public Main()
        {
            InitializeComponent();
            pnlScanedComputers.Dock = DockStyle.Top | DockStyle.Left | DockStyle.Bottom;
            LoadComputers(new ComputerOverviewView());
            LoadScans(new ScanOverviewView());
        }

        private void LoadComputers(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanedComputers.Controls.Add(form);
            form.Show();
        }

        private void LoadScans(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanHistroy.Controls.Add(form);
            form.Show();
        }
    }
}
