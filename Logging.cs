#define LOG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Intcon.W3LF
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

        public enum LogLevels : byte
        {
            Warning = 1,
            Error = 2,
            Information = 4
        }
    }
}
