using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    internal class CustomVisitor : Visitor
    {
        public virtual bool Visit(Logger logger, string tag)
        {
            // 
            logger.Log(tag);
            //
            return true;
        }
    }
}
