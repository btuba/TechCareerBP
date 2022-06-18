﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class MSSqlDBLogger : ConnectableLogger
    {
        public MSSqlDBLogger(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void Log(string message, string user, DateTime date, string logLevel, string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag = "LogLevel", string[] arg = null)
        {
            throw new NotImplementedException();
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public override void View(Color color = Color.White, FontSize fontSize = FontSize.Medium)
        {
            throw new NotImplementedException();
        }
    }
}