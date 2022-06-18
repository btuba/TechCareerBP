using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class Logger
    {
        private string Message { get; set; }
        private string User { get; set; }
        private DateTime Date { get; set; }
        private string LogLevel { get; set; }
        public abstract void Log(string message, string user, DateTime date, string logLevel
            ,string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag= "LogLevel"
            ,params string[] arg);
        public abstract void View(Color color = Color.White, FontSize fontSize = FontSize.Medium);
    }

    public enum Color
    {
        Blue,
        Black,
        Red,
        Yellow,
        White
    }

    public enum FontSize
    {
        Small,
        Medium,
        Large,
    }
}
