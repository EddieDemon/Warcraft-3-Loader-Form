using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Intcon.W3LF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initializes the variable that keeps the Warcraft III path.
            Settings.InitPath();
            if (Environment.CommandLine.ToLower().Contains("-launch"))
            { Loader.RunW3(); return; }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
