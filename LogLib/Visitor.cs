using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLib
{
    public abstract class Visitor
    {
        public virtual bool Visit(Logger logger)
        {
            return false;
        }
    }
}
