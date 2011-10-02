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

// This feature is used for the XPAM edition however, you could use it as well!
#define XPAM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace Intcon.W3LF
{
    /// <summary>
    /// The settings class.
    /// </summary>
    public static class Settings
    {
        #region properties
        /// <summary>
        /// Get the current Warcraft III directory path.
        /// </summary>
        /// <remarks>Call <see cref="Intcon.W3LF.Settings.InitPath()"/> before calling this property.</remarks>
        public static string W3Path { get; private set; }
        /// <summary>
        /// Initializes the <see cref="Intcon.W3LF.Settings.W3Path"/> property.
        /// </summary>
        public static void InitPath()
        {
            W3Path = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32).OpenSubKey("Software\\Blizzard Entertainment\\Warcraft III").GetValue("InstallPath", "C:\\Progra~1\\Warcra~1").ToString();
            Logging.Log(Logging.LogLevels.Information, "Using W3Path: " + W3Path);
        }
#if XPAM
        /// <summary>
        /// Gets whether or not the GProxy configuration file does exist.
        /// </summary>
        public static bool GProxy_Cfg_Exists
        {
            get
            {
                if (Directory.Exists(W3Path))
                    if (File.Exists(W3Path + "/gproxy.cfg")) return true; return false;
            }
        }
        /// <summary>
        /// Gets whether or not the GProxy executable file does exist.
        /// </summary>
        public static bool GProxy_Exe_Exists
        {
            get
            {
                if (Directory.Exists(W3Path))
                    if (File.Exists(W3Path + "/gproxy.exe")) return true; return false;
            }
        }
        /// <summary>
        /// Gets whether or not the GProxy log-file file does exist.
        /// </summary>
        public static bool GProxy_Log_Exists
        {
            get
            {
                if (Directory.Exists(W3Path))
                    if (File.Exists(W3Path + "/gproxy.log")) return true; return false;
            }
        }
        /// <summary>
        /// Gets or sets the current GProxy game port.
        /// </summary>
        public static int GProxy_GamePort
        {
            get
            {
                try // Why do I use Try-Catch: 1. Split exception.  2. Direcrory/File exceptions. - MusicDemon
                {
                    if (GProxy_Cfg_Exists)
                    {
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                                if (line.Split('=')[0].Trim().ToLower() == "game_port")
                                {
                                    int re = -1;
                                    if (int.TryParse(line.Split('=')[1].Trim().ToLower(), out re))
                                        if (re < System.Net.IPEndPoint.MinPort || re > System.Net.IPEndPoint.MaxPort)
                                        {
                                            GProxy_GamePort = 6125; // Reset the value since the value was out of bounds.
                                            re = 6125;
                                        }

                                    return re;
                                }
                        return -1;
                    }
                    else return -1;
                }
                catch (Exception) { return -1; }
            }
            set
            {
                try
                {
                    if (value < System.Net.IPEndPoint.MinPort || value > System.Net.IPEndPoint.MaxPort)
                    {
                        MessageBox.Show("Game Port is invalid! Minimal value: " + System.Net.IPEndPoint.MinPort + " / Maximum value: " + System.Net.IPEndPoint.MaxPort); return;
                    }
                    if (GProxy_Cfg_Exists)
                    {
                        string content = "";
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                            {
                                if (line.Split('=')[0].Trim().ToLower() == "game_port")
                                    content += "game_port = " + value + "\r\n";
                                else content += line + "\r\n";
                            }
                            else content += line + "\r\n";
                        File.WriteAllText(W3Path + "/gproxy.cfg", content);
                        Logging.Log(Logging.LogLevels.Information, "Set GPGP: " + value.ToString());
                    }
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// Gets or sets whether or not to use GProxy built-in sounds.
        /// </summary>
        public static bool GProxy_UseSounds
        {
            get
            {
                try // Why do I use Try-Catch: 1. Split exception.  2. Direcrory/File exceptions. - MusicDemon
                {
                    if (GProxy_Cfg_Exists)
                    {
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                                if (line.Split('=')[0].Trim().ToLower() == "option_sounds")
                                {
                                    if (line.Split('=')[1].Trim().ToLower() == "0") return false;
                                    return true;
                                }
                        return true;
                    }
                    else return true;
                }
                catch (Exception) { return true; }
            }
            set
            {
                try
                {
                    if (GProxy_Cfg_Exists)
                    {
                        string content = "";
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                            {
                                if (line.Split('=')[0].Trim().ToLower() == "option_sounds")
                                    content += "option_sounds = " + (value ? 1 : 0) + "\r\n";
                                else content += line + "\r\n";
                            }
                            else
                                content += line + "\r\n";
                        File.WriteAllText(W3Path + "/gproxy.cfg", content);
                        Logging.Log(Logging.LogLevels.Information, "Set GPUS: " + value.ToString());
                    }
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// Gets or sets whether or not to start GProxy visibly.
        /// </summary>
        public static bool GProxy_Console
        {
            get
            {
                try // Why do I use Try-Catch: 1. Split exception.  2. Direcrory/File exceptions. - MusicDemon
                {
                    if (GProxy_Cfg_Exists)
                    {
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                                if (line.Split('=')[0].Trim().ToLower() == "console")
                                {
                                    if (line.Split('=')[1].Trim().ToLower() == "0") return false;
                                    return true;
                                }
                        return true;
                    }
                    else return true;
                }
                catch (Exception) { return true; }
            }
            set
            {
                try
                {
                    if (GProxy_Cfg_Exists)
                    {
                        string content = "";
                        foreach (string line in File.ReadAllLines(W3Path + "/gproxy.cfg"))
                            if (line.Contains("="))
                            {
                                if (line.Split('=')[0].Trim().ToLower() == "console")
                                    content += "console = " + (value ? 1 : 0) + "\r\n";
                                else content += line + "\r\n";
                            }
                            else
                                content += line + "\r\n";
                        File.WriteAllText(W3Path + "/gproxy.cfg", content);
                        Logging.Log(Logging.LogLevels.Information, "Set GPCL: " + value.ToString());
                    }
                }
                catch (Exception) { }
            }
        }
#endif
        /// <summary>
        /// Gets or sets the current Warcraft III startup options.
        /// </summary>
        public static Loader.StartOptions StartupOptions
        {
            get
            {
                if (File.Exists("./startupoptions"))
                {
                    int re = 0;
                    int.TryParse(File.ReadAllText("./startupoptions"), out re);
                    return (Loader.StartOptions)re;
                }
                return Loader.StartOptions.None;
            }
            set
            {
                try { File.WriteAllText("./startupoptions", ((int)value).ToString()); Logging.Log(Logging.LogLevels.Information, "Set W3ST: " + value.ToString()); }
                catch (Exception) { throw; }
            }
        }
        #endregion
    }
}
