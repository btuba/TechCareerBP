using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class ColoredLoggerDecorator : LoggerDecorator
    {
        public ColoredLoggerDecorator(IViewable viewable) : base(viewable)
        {
        }

        public ColoredLoggerDecorator SetColor(Color color)
        {
            base.viewable.Color = color;
            return this;
        }

        public override void View()
        {
            base.View();
        }
    }
    public enum Color
    {
        Blue,
        Black,
        Red,
        Yellow,
        White
    }
}
