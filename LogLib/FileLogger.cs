using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class FileLogger : Logger
    {
        private string path;
        public TargetFormat targetFormat;
        public FileLogger(string path, TargetFormat targetFormat)
        {
            this.path = path;
            this.targetFormat = targetFormat;
        }

        public override void Log(string message, string user, DateTime date, string logLevel, string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag = "LogLevel", 
            params string[] arg)
        {
            Console.WriteLine($"{message} {user} {date} {logLevel}");
            foreach (var item in arg)
            {
                Console.WriteLine(item);
            }
        }

        public override void View(Color color = Color.White, FontSize fontSize = FontSize.Medium)
        {
            throw new NotImplementedException();
        }
    }
}
