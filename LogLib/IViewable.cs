using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public interface IViewable
    {
        public Color Color { get; set; }
        public FontSize FontSize { get; set; }
        void View();
    }
}
