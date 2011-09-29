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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace Intcon.W3LF
{
    /// <summary>
    /// The main for of W3LF.
    /// </summary>
    public partial class frmMain : Form
    {
        #region Form
        /// <summary>
        /// Initializes a new instance of the <see cref="Intcon.W3LF.frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            // Command line parsing.
            if (Environment.CommandLine.ToLower().Contains("-noupdate"))
            { tcMain.Controls.Remove(tpUpdate); tpUpdate.Dispose(); tpUpdate = null; }
            if (Environment.CommandLine.ToLower().Contains("-nonews"))
            { Controls.Remove(wbNews); wbNews.Dispose(); wbNews = null; }
            // End command line parsing

            Loader.StartOptions Ops = Settings.StartupOptions;
            if (Ops.HasFlag(Loader.StartOptions.Window)) cbWindow.Checked = true;
            if (Ops.HasFlag(Loader.StartOptions.OpenGl)) cbOpenGL.Checked = true;
            if (Ops.HasFlag(Loader.StartOptions.SWTNL)) cbSWTNL.Checked = true;
            if (Ops.HasFlag(Loader.StartOptions.Classic)) cbClassic.Checked = true;

            wbtnWarGP.SetId(1);

            if (Settings.GProxy_Cfg_Exists)
            {
                txtHostport.Text = Settings.GProxy_GamePort.ToString();
                cbSounds.Checked = Settings.GProxy_UseSounds;
                cbConsole.Checked = Settings.GProxy_Console;
            }
            else
            {
                txtHostport.Enabled = false;
                cbSounds.Enabled = false;
                cbConsole.Enabled = false;
                lblNoGP.Visible = true;
            }
        }
        /// <summary>
        /// Represents the method that will handle an event that has no event data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (wbNews != null)
            {
                // Sets the default loading page.
                wbNews.DocumentText = "<html><head><title>Loading...</title><style type=\"text/css\">body { Background-Color: #000; Color: #FFF; }</style></head><body>Loading news...</body></html>";
                // Starts downloading the news content.
                System.Threading.ThreadPool.QueueUserWorkItem(SetHTML);
            }
            // Starts downloading server status.
            System.Threading.ThreadPool.QueueUserWorkItem(SetStatus);
            // Starts the GProxy log check loop.
            System.Threading.ThreadPool.QueueUserWorkItem(GPLog);
            if (tpUpdate != null)
            {
                // Checks for updates.
                System.Threading.ThreadPool.QueueUserWorkItem(UpdateUpdLbl);
            }
        }
        #endregion

        // A set of methods that open an HTTP website.
        #region Links
        /// <summary>
        /// Goes to MusicDemons XPAM user-page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void lblCreatedByMusicDemon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.eurobattle.net/member.php?u=952844");
        }
        /// <summary>
        /// Goes to XPAMs page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void XPAM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.eurobattle.net/");
        }
        /// <summary>
        /// Goes to W3LFs GitHub page.
        /// </summary>
        /// <param name="sender"> The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.LinkLabelLinkClickedEventArgs that contains the event
        ///     data.</param>
        private void llblProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MusicDemon/Warcraft-3-Loader-Form");
        }
        /// <summary>
        /// Goes to Intcons page.
        /// </summary>
        /// <param name="sender"> The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.LinkLabelLinkClickedEventArgs that contains the event
        ///     data.</param>
        private void llblIntcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://intcon.zeusoft.net");
        }
        /// <summary>
        /// Goes to the PvPGN forums.
        /// </summary>
        /// <param name="sender"> The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.LinkLabelLinkClickedEventArgs that contains the event
        ///     data.</param>
        private void llblPvPGN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forums.pvpgn.org");
        }
        /// <summary>
        /// Goes to W3Ls page.
        /// </summary>
        /// <param name="sender"> The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.LinkLabelLinkClickedEventArgs that contains the event
        ///     data.</param>
        private void llblW3L_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://w3l.info.tm");
        }
        #endregion

        // Start Warcraft III button handlers
        #region Start
        /// <summary>
        /// Starts Warcraft III
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void wbtnWar3_Click(object sender, EventArgs e)
        {
            Loader.RunW3(false);
        }
        /// <summary>
        /// Starts Warcraft III and GProxy.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void wbtnWarGP_Click(object sender, EventArgs e)
        {
            Program.LaunchW3GP();
        }
        #endregion

        #region Updating
        /// <summary>
        /// Goes to Blizzards FTP patches page for PC Warcraft III: The Frozen Throne.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnWarUpdDL_Click(object sender, EventArgs e)
        {
            //Send them to a default download URL.
            if (Updata[0] == "-1") { System.Diagnostics.Process.Start("http://ftp.blizzard.com/pub/war3x/patches/pc/"); return; }
            DoUpdate(0);
        }
        // HACK: Shouldn't this point to Steffs page?
        /// <summary>
        /// Goes to XPAMs page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnGPUpdDL_Click(object sender, EventArgs e)
        {
            //Send them to a default download URL.
            if (Updata[1] == "-1") { System.Diagnostics.Process.Start("http://www.eurobattle.net/index.php"); return; }
            DoUpdate(1);
        }
        /// <summary>
        /// Goes to XPAMs page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnELUpdDL_Click(object sender, EventArgs e)
        {
            //Send them to a default download URL.
            if (Updata[2] == "-1") { System.Diagnostics.Process.Start("http://www.eurobattle.net/index.php"); return; }
            DoUpdate(2);
        }
        /// <summary>
        /// Starts checking for new updates.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void btnELUpdRef_Click(object sender, EventArgs e)
        {
            btnWarUpdDL.Enabled = false;
            btnGPUpdDL.Enabled = false;
            btnELUpdDL.Enabled = false;
            btnELUpdRef.Enabled = false;
            System.Threading.Thread Trd = new System.Threading.Thread(UpdateUpdLbl);
            Trd.Start();
        }
        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="Id">The Id of the application.</param>
        void DoUpdate(int Id)
        {
            btnWarUpdDL.Enabled = false;
            btnGPUpdDL.Enabled = false;
            btnELUpdDL.Enabled = false;
            btnELUpdRef.Enabled = false;
            tcMain.Enabled = false;
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            try
            {
                if (!Directory.Exists("./temp"))
                    Directory.CreateDirectory("./temp");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to detect or create the directory \"temp\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                wc.DownloadFileAsync(new Uri(Updata[Id]), "./temp/" + (Id == 0 ? "w3upd.exe" : (Id == 1 ? "gproxy.exe" : Program.W3LFExeName)), Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception was thrown while downloading/saving the update.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnWarUpdDL.Enabled = true;
                btnGPUpdDL.Enabled = true;
                btnELUpdDL.Enabled = true;
                btnELUpdRef.Enabled = true;
                tcMain.Enabled = true;
            }
        }
        /// <summary>
        /// Issues update sequences for an application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.ComponentModel.AsyncCompletedEventArgs that contains the event data.</param>
        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.UserState is int)
            {
                int id = (int)e.UserState;
                try
                {
                    switch (id)
                    {
                        case 0:
                            try { Process.GetProcessesByName("war3.exe")[0].Kill(); }
                            catch (Exception) { }
                            Process.Start("./temp/w3upd.exe");
                            break;
                        case 1:
                            try { Process.GetProcessesByName("gproxy.exe")[0].Kill(); }
                            catch (Exception) { }
                            try
                            {
                                File.Move("./temp/gproxy.exe", Settings.W3Path + "/gproxy.exe");
                            }
                            catch (Exception) { MessageBox.Show("Unable to replace the old gproxy.exe with the new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            break;
                        case 2:
                            File.Move(Application.ExecutablePath, Application.ExecutablePath + ".old");
                            File.Move("./temp/" + Program.W3LFExeName, Program.W3LFExeName);
                            MessageBox.Show("Downloading has been completed and the application has been replaced.\r\nApplication must restart before changes take effect.", "Restart required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Restart();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex) { MessageBox.Show("An exception was thrown while updating an application.\r\n\r\nMessage:\r\n" + ex.Message, "Error while updating", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                try
                {
                    Directory.Delete("./temp", true);
                }
                catch (Exception) { }
                btnWarUpdDL.Enabled = true;
                btnGPUpdDL.Enabled = true;
                btnELUpdDL.Enabled = true;
                btnELUpdRef.Enabled = true;
                tcMain.Enabled = true;
            }
        }
        #endregion

        #region ASync
        // Creates the news page.
        void SetHTML(object HTML)
        {
            try
            {
                if (InvokeRequired)
                {
                    System.Threading.Thread.Sleep(25);
                    string C = new System.Net.WebClient().DownloadString("http://www.eurobattle.net/");
                    HTML = ("<html>\r\n<head>" + C.Split(new string[] { "<head>", "</head>" }, StringSplitOptions.RemoveEmptyEntries)[1] + "</head>" +
                       "<body><div id=\"vba_news4\">" + C.Split(new string[] { "<div id=\"vba_news4\">" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "<script type=\"text/javascript\">" }, StringSplitOptions.RemoveEmptyEntries)[0] + "</body>\r\n</html>");
                    Invoke(new Action<string>(SetHTML), new object[] { HTML });
                    return;
                }
                wbNews.Document.Write((string)HTML);
            }
            catch (ObjectDisposedException) { }
            catch (System.Net.WebException)
            {
                Invoke(new Action<string>(SetHTML), "<html><head><title>An exception was thrown.</title><style type=\"text/css\">body { Background-Color: #000; Color: #FFF; }</style></head><body><div>An exception was thrown while loading the page. (System.Net.WebException)</div>" +
                    "<div>A possible cause is: No internet connection.</div></body></html>");
            }
        }
        // Gets the online status of the game server.
        void SetStatus(object Status)
        {
            try
            {
                if (InvokeRequired)
                {
                    System.Threading.Thread.Sleep(25);
                    Invoke(new Action<string>(SetStatus), new object[] { new System.Net.WebClient().DownloadString("http://app2.eurobattle.net/tstatus/index_navbar.php").Split(new string[] { "background-image: url(user_", ".gif);" }, StringSplitOptions.RemoveEmptyEntries)[1] });
                    return;
                }
                lblStatus.Text = "Server is currently: " + (string)Status;
            }
            catch (ObjectDisposedException) { }
            catch (System.Net.WebException) { Invoke(new Action<string>(SetStatus), "An exception was thrown. (No internet connection?)"); }
        }
        // Checks if GProxy has changed and updates txtGPLog/
        void GPLog(object e)
        {
            while (!this.IsDisposed)
            {
                if (Settings.GProxy_Log_Exists)
                {
                    string c = File.ReadAllText(Settings.W3Path + "/gproxy.log");
                    if (c != txtGPLog.Text)
                        UpdateGPLog(c);
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        // Updates txtGPLog
        void UpdateGPLog(object txt)
        {
            if (txt is string)
                if (InvokeRequired) { Invoke(new Action<object>(UpdateGPLog), txt); return; }
            txtGPLog.Text = (string)txt;
        }

        Dictionary<int, string> Updata = new Dictionary<int, string>();
        // Updates the labels on the update form.
        void UpdateUpdLbl(object e)
        {
            System.Threading.Thread.Sleep(25);
            Updata = UpdateManager.RefreshUpdates();

            /* id:
             * 0 = war
             * 1 = gp
             * 2 = w3lf
             */
            foreach (KeyValuePair<int, string> element in Updata)
            {
                switch (element.Key)
                {
                    case 0:
                        DoUpdLbl(lblWarUpd, btnWarUpdDL, (element.Value == "-1" ? 0 : (element.Value == "err" ? 2 : 1)));
                        break;
                    case 1:
                        DoUpdLbl(lblGPUpd, btnGPUpdDL, (element.Value == "-1" ? 0 : (element.Value == "err" ? 2 : 1)));
                        break;
                    case 2:
                        DoUpdLbl(lblELUpd, btnELUpdDL, (element.Value == "-1" ? 0 : (element.Value == "err" ? 2 : 1)));
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        ///  Updates the labels with the right text.
        /// </summary>
        /// <param name="lbl">The label to edit.</param>
        /// <param name="btn">Button to turn on if an update is available.</param>
        /// <param name="status">Status Id of the update.
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>Status Ids</term>
        ///         <description>The possible Ids.</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0) No updates available; Up-to-date.</term>
        ///         <description>The up-to-date status Id.</description>
        ///     </item>
        ///     <item>
        ///         <term>1) An update is available.</term>
        ///         <description>The new update status Id.</description>
        ///     </item>
        ///     <item>
        ///         <term>2) An error occured while loading update data.</term>
        ///         <description>The error status Id.</description>
        ///     </item>
        /// </list>
        /// </param>
        void DoUpdLbl(Label lbl, Button btn, int status)
        {
            if (InvokeRequired) { Invoke(new Action<Label, Button, int>(DoUpdLbl), new object[] { lbl, btn, status }); return; }
            if (!btnELUpdRef.Enabled) btnELUpdRef.Enabled = true;
            switch (status)
            {
                case 0:
                    lbl.Text = "Status: Up-to-date";
                    btn.Enabled = false;
                    break;
                case 1:
                    lbl.Text = "Status: Update available";
                    btn.Enabled = true;
                    break;
                case 2:
                    lbl.Text = "Status: Error";
                    btn.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        // TODO: Check if war3.exe or gproxy.exe are running.
        #endregion
        /// <summary>
        /// Handles the navigating event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.WebBrowserNavigatingEventArgs that contains the event data.</param>
        void wbNews_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Navigating is allowed! DO NOT CHANGE THAT!
            // about:blank is only called for loading the default page, everything other than that will be send to the default webbrowser.
            if (e.Url.AbsoluteUri != "about:blank") { System.Diagnostics.Process.Start(e.Url.AbsoluteUri); e.Cancel = true; }
        }

        // Used to determine whether or not the options tab has been opened last.
        bool OpsLast = false;
        /// <summary>
        /// Handles the tab selecting.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.TabControlCancelEventArgs that contains the event data.</param>
        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // This resets the background value of the TabPages.
            //  Don't remove this, the image itself is quite big, that times the amount of tabs is quite some spilled memory! - MusicDemon
            tpMainMenu.BackgroundImage = null;
            tpOptions.BackgroundImage = null;
            tpGPLog.BackgroundImage = null;
            tpAbout.BackgroundImage = null;
            if (tpUpdate != null) tpUpdate.BackgroundImage = null;
            e.TabPage.BackgroundImage = Properties.Resources.bg;
            if (OpsLast)
            {
                OpsLast = false;
                Loader.StartOptions Ops = Loader.StartOptions.None;
                if (cbWindow.Checked) Ops |= Loader.StartOptions.Window;
                if (cbOpenGL.Checked) Ops |= Loader.StartOptions.OpenGl;
                if (cbSWTNL.Checked) Ops |= Loader.StartOptions.SWTNL;
                if (cbClassic.Checked) Ops |= Loader.StartOptions.Classic;
                Settings.StartupOptions = Ops;
                if (Settings.GProxy_Cfg_Exists)
                {
                    int port = -1;
                    int.TryParse(txtHostport.Text, out port);
                    Settings.GProxy_GamePort = port;
                    Settings.GProxy_UseSounds = cbSounds.Checked;
                    Settings.GProxy_Console = cbConsole.Checked;
                }
            }
            if (e.TabPage.Name == "tpOptions")
            {
                Loader.StartOptions Ops = Settings.StartupOptions;
                if (Ops.HasFlag(Loader.StartOptions.Window)) cbWindow.Checked = true;
                if (Ops.HasFlag(Loader.StartOptions.OpenGl)) cbOpenGL.Checked = true;
                if (Ops.HasFlag(Loader.StartOptions.SWTNL)) cbSWTNL.Checked = true;
                if (Ops.HasFlag(Loader.StartOptions.Classic)) cbClassic.Checked = true;

                if (Settings.GProxy_Cfg_Exists)
                {
                    txtHostport.Text = Settings.GProxy_GamePort.ToString();
                    cbSounds.Checked = Settings.GProxy_UseSounds;
                    cbConsole.Checked = Settings.GProxy_Console;
                }
                else
                {
                    txtHostport.Enabled = false;
                    cbSounds.Enabled = false;
                    cbConsole.Enabled = false;
                    lblNoGP.Visible = true;
                }
                OpsLast = true;
            }
        }
    }
}