using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal interface IConnectableLoggerBuilder
    {
        IConnectableLoggerBuilder SetConectionString(string connection);
        IConnectableLoggerBuilder SetDb(DB database);
        Logger Create();
    }
}
