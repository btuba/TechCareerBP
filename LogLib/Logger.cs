using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class Logger : IViewable
    {
        public string Message { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string LogLevel { get; set; }
        public Color Color { get; set; }
        public FontSize FontSize { get; set; }

        public abstract void Log(string messageTag = "Message", string userTag = "User", string dateTag = "Tag", string logeLevelTag= "LogLevel"
            ,params string[] arg);

        public abstract bool Accept(Visitor visitor);

        public abstract void View();
    }
}
