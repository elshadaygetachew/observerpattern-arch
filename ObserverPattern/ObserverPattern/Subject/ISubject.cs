using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    public interface ISubject
    {
        void RegisterObserver(Observer.IObserver observer);
        void UnregisterObserver(Observer.IObserver observer);
        void NotifyObserver(int Count);
    }
}
