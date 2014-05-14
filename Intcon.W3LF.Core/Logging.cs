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

#define LOG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CPlan.W3LF
{
    /// <summary>
    /// A simple file logger.
    /// </summary>
    static class Logging
    {
#if LOG
        static string LogPath = "w3lf.log";
#endif
        public static void Log(LogLevels level, string text)
        {
#if LOG
            if (!File.Exists(LogPath))
            {
                File.WriteAllText(LogPath, "Executable: " + Application.ExecutablePath + "\r\n" +
                    "Version: " + Application.ProductVersion + "\r\n" +
                    "Installed .Net Framework: " + typeof(object).Assembly.GetName().Version.ToString() + "\r\n" +
                    "OS: " + Environment.OSVersion.VersionString + "\r\n", Encoding.UTF8);
            }
            switch (level)
            {
                case LogLevels.Warning:
                    text = "[WARN] " + text;
                    break;
                case LogLevels.Error:
                    text = "[ERRO] " + text;
                    break;
                case LogLevels.Information:
                default:
                    text = "[INFO] " + text;
                    break;
            }
            File.AppendAllLines(LogPath, new string[] { text }, Encoding.UTF8);
#endif
        }
        /// <summary>
        /// Different logging levels
        /// </summary>
        public enum LogLevels : byte
        {
            /// <summary>
            /// Describes a warning.
            /// </summary>
            Warning = 1,
            /// <summary>
            /// Describes an error.
            /// </summary>
            Error = 2,
            /// <summary>
            /// Describes information.
            /// </summary>
            Information = 4
        }
    }
}
