using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public interface IObserver
    {
        void SendNotification(Observable observable);
    }
}
