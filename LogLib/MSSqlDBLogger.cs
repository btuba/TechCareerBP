using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class MSSqlDBLogger : ConnectableLogger
    {
        public MSSqlDBLogger()
        {
            
        }
        protected override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void Log(string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag = "LogLevel", string[] arg = null)
        {
            OpenConnection();
            // log
            CloseConnection();
        }

        protected override void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public override bool Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }

        public override void View()
        {
            throw new NotImplementedException();
        }
    }
}
