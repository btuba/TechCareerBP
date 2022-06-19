using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class ConnectableLogger : Logger
    {
        internal string connectionString;
        protected abstract void OpenConnection();
        protected abstract void CloseConnection();
    }
}
