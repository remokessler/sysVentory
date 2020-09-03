using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysVentory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*MaterialSkinManager.Instance.ROBOTO_MEDIUM_10 = new Font("Arial", 11);
            MaterialSkinManager.Instance.ROBOTO_MEDIUM_11 = new Font("Arial", 11);
            MaterialSkinManager.Instance.ROBOTO_MEDIUM_12 = new Font("Arial", 11);
            MaterialSkinManager.Instance.ROBOTO_REGULAR_11 = new Font("Arial", 11);*/
            MaterialSkinManager.Instance.ROBOTO_MEDIUM_10 = new Font(MaterialSkinManager.Instance.ROBOTO_MEDIUM_12.FontFamily, 12);
            Application.Run(new Main());
        }
    }
}
