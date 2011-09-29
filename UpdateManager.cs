using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace Intcon.W3LF
{
    /// <summary>
    /// The update manager of the application.
    /// </summary>
    static class UpdateManager
    {
        // TODO: Change the path.
        readonly static string UpdateUrl = "./update.htm";
        /* Using System.int as an Id for the product.
         *  0 = war3
         *  1 = GProxy
         *  2 = W3LF
         *  
         * The string is the download path.
         */
        /// <summary>
        /// Gets a dictionary with application Ids and update values.
        /// </summary>
        /// <returns>A full <see cref="SystemCollections.Generic.Dictionary<TKey, TValue>"/> class.</returns>
        public static Dictionary<int, string> RefreshUpdates()
        {
            if (!File.Exists(Settings.W3Path + "/war3.exe"))
                do
                {
                    DoCheck();
                } while (!File.Exists(Settings.W3Path + "/war3.exe"));
            string War3 = "";
            string GPHash = "";
            string W3LF = "";
            try { War3 = GetMD5Hash(System.Diagnostics.FileVersionInfo.GetVersionInfo(Settings.W3Path + "/Game.dll").FileVersion); /* Game.dll. The file version is plain C (?) "1, 2, 3, 4" */           }
            catch (Exception) { }
            try { GPHash = GetMD5Hash(File.ReadAllText(Settings.W3Path + "/gproxy.exe")); /* Check on the whole hash, since there's no version information. - MusicDemon */           }
            catch (Exception) { }
            try { W3LF = GetMD5Hash(System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion); }
            catch (Exception) { }
            Dictionary<int, string> re = new Dictionary<int, string>() { { 0, "-1" }, { 1, "-1" }, { 2, "-1" } };
            try
            {
                foreach (string line in new System.Net.WebClient().DownloadString(UpdateUrl).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.Contains('|'))
                    {
                        switch (line.Split('|')[0].ToLower())
                        {
                            case "war3":
                                if (War3 != "" && (line.Split('|')[1].ToLower() != War3))
                                    DoAdd(ref re, 0, line);
                                break;
                            case "gp":
                                if (GPHash != "" && (line.Split('|')[1].ToLower() != GPHash))
                                    DoAdd(ref re, 1, line);
                                break;
                            case "w3lf":
                                if (W3LF != "" && (line.Split('|')[1].ToLower() != W3LF))
                                    DoAdd(ref re, 2, line);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (System.Net.WebException)
            {
                DoAdd(ref re, 0, "err");
                DoAdd(ref re, 1, "err");
                DoAdd(ref re, 2, "err");
            }

            return re;
        }
        /// <summary>
        /// Requests a new path to war3.exe.
        /// </summary>
        static void DoCheck()
        {
            if (Application.OpenForms[0].InvokeRequired)
            {
                Application.OpenForms[0].Invoke(new Action(DoCheck));
                return;
            }
            else
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Eurobattle.exe could not find war3.exe, please search for a folder containing war3.exe.";
                    fbd.ShowNewFolderButton = false;
                    switch (fbd.ShowDialog())
                    {
                        case DialogResult.OK:
                        case DialogResult.Yes:
                            RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32).OpenSubKey("Software\\Blizzard Entertainment\\Warcraft III", true).SetValue("InstallPath", fbd.SelectedPath);
                            Settings.InitPath();
                            break;
                        case DialogResult.Abort:
                        case DialogResult.Cancel:
                        case DialogResult.Ignore:
                        case DialogResult.No:
                        case DialogResult.None:
                        case DialogResult.Retry:
                        default:
                            break;
                    }
                }
        }
        /// <summary>
        /// Adds a new value to an applcation update value.
        /// </summary>
        /// <param name="Dict">The dictionary to add the value to.</param>
        /// <param name="Id">The Id of the applcation.</param>
        /// <param name="line">The HTML-response-line</param>
        static void DoAdd(ref Dictionary<int, string> Dict, int Id, string line)
        {
            try
            {
                if (line.Split('|').Length == 3)
                    Dict[Id] = line.Split('|')[2];
                else
                    Dict[Id] = null;
            }
            catch (Exception)
            {
                try { Dict[Id] = "err"; }
                catch (Exception) { }
            }

        }
        /// <summary>
        /// Creates an MD5 hash from a string.
        /// </summary>
        /// <param name="input">The input string of the MD5 hash.</param>
        /// <returns>The hashed interpretation of input.</returns>
        static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
                s.Append(b.ToString("x2").ToLower());
            return s.ToString();
        }
    }
}
