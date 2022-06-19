using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    internal class OracleDBLogger : ConnectableLogger
    {
        public OracleDBLogger()
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

        public override void View(Color color = Color.White, FontSize fontSize = FontSize.Medium)
        {
            throw new NotImplementedException();
        }

        public override bool Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
