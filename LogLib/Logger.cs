using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class Logger
    {
        public string Message { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string LogLevel { get; set; }

        public abstract void Log(string messageTag = "Message", string userTag = "User", string dataTag = "Tag", string logeLevelTag= "LogLevel"
            ,params string[] arg);
        public abstract void View(Color color = Color.White, FontSize fontSize = FontSize.Medium);

        public abstract bool Accept(Visitor visitor);
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
