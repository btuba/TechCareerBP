using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class FileLogger : Logger
    {
        internal string Path { get; set; }
        internal TargetFormat targetFormat;

        public override void Log(string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag = "LogLevel", 
            params string[] arg)
        {
            Console.WriteLine($"{Message} {User} {Date} {LogLevel}");
            foreach (var item in arg)
            {
                Console.WriteLine(item);
            }
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
