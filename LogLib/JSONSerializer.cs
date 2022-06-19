using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal class JSONSerializer : ISerializer
    {
        public Settings Serialize(string configFile)
        {
            return new Settings();
        }
    }
}
