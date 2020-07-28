using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysVentory
{
    public partial class Exit : UserControl
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
