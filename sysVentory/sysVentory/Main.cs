using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sysVentory.Views;

namespace sysVentory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            NavigateTo(new ScanOverview());
        }

        private void NavigateTo(Form form)
        {
            form.TopLevel = false;
            PnlContent.Controls.Clear();
            PnlContent.Controls.Add(form);
            form.Show();
        }
    }
}
