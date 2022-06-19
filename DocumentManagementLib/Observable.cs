using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public abstract class Observable
    {
        private List<IObserver> _observers;

        public Observable()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(Observable observable)
        {
            foreach (IObserver observer in _observers)
            {
                observer.SendNotification(observable);
            }
        }
    }
}
