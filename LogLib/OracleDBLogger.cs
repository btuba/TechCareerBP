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
            Console.WriteLine("ORACLE Connection closed.");
        }

        public override void Log(string messageTag = "Message", string userTag = "User", string dateTag = "Tag", string logeLevelTag = "LogLevel", string[] arg = null)
        {
            OpenConnection();
            // log
            CloseConnection();
        }

        protected override void OpenConnection()
        {
            Console.WriteLine("ORACLE Connection opened...");
        }

        public override bool Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }

        public override void View()
        {
            Console.WriteLine($"{this.Color} {this.FontSize} {Message} {User} {Date} {LogLevel}");
        }
    }
}
