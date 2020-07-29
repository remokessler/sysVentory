using System.Windows.Forms;
using sysVentory.Helper;
using sysVentory.Views;

namespace sysVentory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pnlScanedComputers.Dock = DockStyle.Top | DockStyle.Left | DockStyle.Bottom;
            LoadComputers(new ScanedComputers());
            LoadHistory(new ScanHistory());
        }

        public void LoadComputers(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanedComputers.Controls.Add(form);
            form.Show();
            return;
        }

        public void LoadHistory(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlScanHistroy.Controls.Add(form);
            form.Show();
            return;
        }
    }
}
