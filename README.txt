W3LF - Warcraft 3 Loader Form

A modification for the original W3L by Rupan, Keres & Phatdeeva. This version makes it possible to start Warcraft 3 with paramaters with ease.
w3l.c.txt is the actual w3l.c file used for the loading.

The original release of W3LF was created for Eurobattle.net (http://www.eurobattle.net/index.php)

For developers: It you'd like to create your own forms application then use the API:

[code]
[DllImport("w3l.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern Int32 DoInject(
            [MarshalAs(UnmanagedType.LPStr)] string CommandLine,
            [MarshalAs(UnmanagedType.LPStr)] string ExePath,
            [Out][MarshalAs(UnmanagedType.LPStr)] out string ErrorMsg
            );
[/code]

Simple:
[code]
[DllImport("w3l.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern Int32 DoInject(string CommandLine, string, ExePath, out string ErrorMsg);
[/code]

For version information please see: Version info.txt

Other than that we wish you good luck with W3LF!

Signed; Intcon developer(s) - MusicDemon