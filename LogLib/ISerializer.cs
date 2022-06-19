using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal interface ISerializer
    {
        Settings Serialize(string configFile);
    }
}
