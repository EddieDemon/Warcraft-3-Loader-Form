/*
 *    Warcraft 3 Loader Form - A C# forms application modification upon the original W3L by Acid and Keres
 *	Copyright (C) 2011  MusicDemon
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;

namespace Intcon.W3LF
{
    /// <summary>
    /// Root class of the application.
    /// </summary>
    static class Program
    {
        // Name of the executable. - MusicDemon / Cen
        public static string W3LFExeName = "Eurobattle.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // See frmMain.wc_DownloadFileCompleted() for more information.
            if (System.IO.File.Exists(Application.ExecutablePath + ".old"))
                System.IO.File.Delete(Application.ExecutablePath + ".old");
            // Since users can change names as well, we will check it before using.
            W3LFExeName = Application.ExecutablePath.Split('\\')[Application.ExecutablePath.Split('\\').Length - 1];
            // Initializes the variable that keeps the Warcraft III path.
            Settings.InitPath();
            Logging.Log(Logging.LogLevels.Information, "[BOOT] Ext GPCF: " + Settings.GProxy_Cfg_Exists);
            Logging.Log(Logging.LogLevels.Information, "[BOOT] Ext GPEX: " + Settings.GProxy_Exe_Exists);
            Logging.Log(Logging.LogLevels.Information, "[BOOT] Ext GPLG: " + Settings.GProxy_Log_Exists);
            Logging.Log(Logging.LogLevels.Information, "[BOOT] Ext GPLG: " + Settings.GProxy_Log_Exists);
            // Command line parsing.
            if (Environment.CommandLine.ToLower().Contains("-launch"))
            { Loader.RunW3(false); return; }
            else if (Environment.CommandLine.ToLower().Contains("-launchgp"))
            {
                if (Settings.GProxy_Exe_Exists)
                    System.Diagnostics.Process.Start(Settings.W3Path + "/gproxy.exe");
                Loader.RunW3(true);
                return;
            }
            // End command line parsing.
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        /// <summary>
        /// Handles any uncaught exceptions.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A System.Threading.ThreadExceptionEventArgs that contains the event data.</param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception was thrown. Please contact the Eurobattle (This program). Writing exception dump...", "Unhandled exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                if (!Directory.Exists("./errors"))
                    Directory.CreateDirectory("./errors");
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                string fn = "./errors/" + DateTime.Now.ToString().Replace(':', '_') + ".bin";
                FileStream fs = null;
                if (!File.Exists(fn))
                    fs = File.Create(fn);
                else
                    fs = File.OpenWrite(fn);
                bin.Serialize(fs, e.Exception);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to write exception dump. Please make a screen shot and contact the Eurobattle (This program) administrator.\r\n\r\n" + e.Exception.StackTrace);
            }
        }
    }
}
