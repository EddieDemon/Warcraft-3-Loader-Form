W3LF - Warcraft 3 Loader Form
=============================

A modification for the original W3L by Rupan, Keres & Phatdeeva. This version makes it possible to start Warcraft 3 with paramaters with ease.
w3l.c.txt is the actual w3l.c file used for the loading.

The original release of W3LF was created for Eurobattle.net (http://www.eurobattle.net/index.php)

For developers: It you'd like to create your own forms application then use the API:

	[DllImport("w3l.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
	static extern Int32 DoInject(string CommandLine, string, ExePath, out string ErrorMsg);

Since version 2.25.17.2: For developers! loader.cs now has a class that helps you ease the way of gateway "forcing" set the values in the static class and they will be used at start-up!

Since version 2.17.14.1 W3LF will check the registry (Gateways) before booting war3.exe.

Since version 2.7.12.0 W3LF supports commandline arguments. Here's a list of commands and what they do,

> -launch		- Directly launches Warcraft III after loading the set command line arguments. (Warcraft III command lines)

> -launchgp	- Directly launches Warcraft III and GProxy after loading the set command line arguments. (Warcraft III command lines)

> -noupdate	- Does not show the updates-tab.

> -nonews		- Does not show the webbrowser at startup.

For version information please see: Version info.txt (https://github.com/MusicDemon/Warcraft-3-Loader-Form/blob/master/W3LF/Version%20info.txt)

Other than that we wish you good luck with W3LF!

Signed; Intcon developer(s) - MusicDemon