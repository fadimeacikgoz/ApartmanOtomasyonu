using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APARTMAN_OTOMASYONU11
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
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FrmAdmin());
        }
    }
}
