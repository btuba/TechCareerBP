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
            Console.WriteLine("MSSQL Connection closed.");
        }

        public override void Log(string messageTag = "Message", string userTag = "User", string dateTag = "Tag", string logeLevelTag = "LogLevel", string[] arg = null)
        {
            OpenConnection();
            Console.WriteLine($"{messageTag} {Message} {userTag} {User} {dateTag} {Date} {logeLevelTag} {LogLevel}");
            CloseConnection();
        }

        protected override void OpenConnection()
        {
            Console.WriteLine("MSSQL Connection opened...");
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
