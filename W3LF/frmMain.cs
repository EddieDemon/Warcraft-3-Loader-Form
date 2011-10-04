/*
 *  Warcraft 3 Loader Form - A C# forms application modification upon the original W3L by Acid and Keres
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

using System;
using System.Windows.Forms;
using Microsoft.Win32; // Used to use the RegistryKey class.
using System.IO; // Used for the check if war3.exe exists.

namespace Intcon.W3LF
{
    /// <summary>
    /// Main form of <see cref="Intcon.W3LF"/>.
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Intcon.W3LF.frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the <see cref="System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Loads the start-up options into the form...
            Loader.StartOptions opt = Settings.StartupOptions;
            // Check if opt has some start-up flags.
            // If so, mark the right CheckBox as checked.
            if (opt.HasFlag(Loader.StartOptions.Classic)) cbClassic.Checked = true;
            if (opt.HasFlag(Loader.StartOptions.OpenGl)) cbOpenGL.Checked = true;
            if (opt.HasFlag(Loader.StartOptions.SWTNL)) cbSWTNL.Checked = true;
            if (opt.HasFlag(Loader.StartOptions.Window)) cbWindow.Checked = true;
        }
        /// <summary>
        /// Saves the new Warcraft III start-up settings.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Loader.StartOptions variable with None as default flag.
            // None means really no startup flag at all.
            Loader.StartOptions opt = Loader.StartOptions.None;

            /*
             * Explained:
             * The operator | means or.
             * In an If...Else statement it would look like this:
             * <code>
             * bool A = true;
             * bool B = false;
             * if (A == true || B == true)
             * {
             * Console.WriteLine("A or B is true");
             * }
             * </code>
             * 
             * To add a flag to an enum use |= (Or is)
             * 
             * I'm not such an expert to tell you how it works in detail however, it has something to do with bit comparing. (Refer to Wikipedia.)
             */
            if (cbClassic.Checked) opt |= Loader.StartOptions.Classic;
            if (cbOpenGL.Checked) opt |= Loader.StartOptions.OpenGl;
            if (cbSWTNL.Checked) opt |= Loader.StartOptions.SWTNL;
            if (cbWindow.Checked) opt |= Loader.StartOptions.Window;

            // Let the settings class handle the rest.
            Settings.StartupOptions = opt;
        }
        /// <summary>
        /// Starts Warcraft III.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Create a dummy to save the path to war3.exe
            string w3path = @"C:\Program Files\Warcraft III\war3.exe";
            // Check if war3.exe exists in the default installation directory.
            if (File.Exists(w3path))
                Loader.RunW3(); // If it does, start Warcraft III!
            else
            {
                // If it doesn't try the registry!
                try // However; Do it safe, it can give an exception, so catch and handle it.
                {
                    // Try to get the value from the registry...
                    w3path = Path.Combine(Registry.CurrentUser.OpenSubKey(@"Software\Blizzard Entertainment\Warcraft III").GetValue("InstallPath").ToString(), "war3.exe");
                }
                catch (Exception)
                {
                    // Seems like it gave an error, let the user find it for himself...
                    MessageBox.Show("An exception was thrown while getting the installation path from the registry. Please select the location of war3.exe manually.",
                        "Registry exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Create a new form that will help your users to find war3.exe.
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Executable files|*.exe|All files|*.*"; // Create a filter that will only allow extensions like: *.exe or everything else. (*.*).
                    ofd.RestoreDirectory = true;
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        w3path = ofd.FileName;
                }
                // Check for war3.exe once more, if it doesn't give a message and exit the method.
                if (File.Exists(w3path))
                    Loader.RunW3();
                else
                    MessageBox.Show("war3.exe was nowhere to find, please retry by pressing the Start Warcraft III button.", "No war3.exe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}


/* Back-up for the documentation text.
/// <summary>
/// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in Windowed mode.
/// </summary>
private System.Windows.Forms.CheckBox cbWindow;
/// <summary>
/// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in OpenGL mode.
/// </summary>
private System.Windows.Forms.CheckBox cbOpenGL;
/// <summary>
/// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in Software Transform and Lighting Video mode.
/// </summary>
private System.Windows.Forms.CheckBox cbSWTNL;
/// <summary>
/// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in classic mode. (Reign of Chaos)
/// </summary>
private System.Windows.Forms.CheckBox cbClassic;
/// <summary>
/// The <see cref="System.Windows.Forms.Button"/> to save the settings with.
/// </summary>
private System.Windows.Forms.Button btnSave;
/// <summary>
/// The <see cref="System.Windows.Forms.Button"/> to start Warcraft III with.
/// </summary>
private System.Windows.Forms.Button btnStart;
 */