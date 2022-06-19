using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class LoggerDecorator : IViewable
    {
        public IViewable viewable;
        public LoggerDecorator(IViewable viewable)
        {
            this.viewable = viewable;
        }
        public Color Color { get; set; } = Color.White;
        public FontSize FontSize { get; set; } = FontSize.Medium;

        public virtual void View()
        {
            viewable.View();
        }
    }
}
