using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPlan.W3LF
{
    sealed class Gateway
    {
        public Uri Hostname { get; set; }
        public int TimeZone { get; set; }
        public string Name { get; set; }

        public Gateway(Uri hostName, int timeZone, string name)
        {
            Hostname = hostName;
            TimeZone = timeZone;
            Name = name;
            Found = false;
        }
    }
}
