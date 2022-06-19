using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public class SizedLoggerDecorator : LoggerDecorator
    {
        public SizedLoggerDecorator(IViewable viewable) : base(viewable)
        {
        }

        public SizedLoggerDecorator SetFontSize(FontSize fontSize)
        {
            base.viewable.FontSize = fontSize;
            return this;
        }

        public override void View()
        {
            base.View();
        }
    }

    public enum FontSize
    {
        Small,
        Medium,
        Large,
    }
}
