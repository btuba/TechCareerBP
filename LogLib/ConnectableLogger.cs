using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class ConnectableLogger : Logger
    {
        protected string connectionString;
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
