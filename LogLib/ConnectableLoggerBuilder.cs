using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal class ConnectableLoggerBuilder : IConnectableLoggerBuilder
    {
        ConnectableLogger logger;

        public Logger Create()
        {
            return logger;
        }

        public IConnectableLoggerBuilder SetConectionString(string connection)
        {
            logger.connectionString = connection;
            return this;
        }

        public IConnectableLoggerBuilder SetDb(DB database)
        {
            switch (database)
            {
                case DB.ORACLE:
                    logger = new OracleDBLogger();
                    break;
                case DB.MSSQL:
                    logger = new MSSqlDBLogger();
                    break;
            }
            return this;
        }
    }
    internal enum DB
    {
        ORACLE,
        MSSQL
    }
}
