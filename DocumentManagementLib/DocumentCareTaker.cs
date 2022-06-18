using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class DocumentCareTaker
    {
        private Stack<Document> _mementos;
        public DocumentCareTaker()
        {
            _mementos = new Stack<Document>();
        }
        public Document Document
        {
            get { return _mementos.Pop(); }
            set { _mementos.Push(value); }
        }
    }
}
