using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Counter : ISubject
    {
        private List<IObserver> observers;
        private int Count;

        public Counter()
        {
            observers = new List<IObserver>();
            Count = 0;


        }
        public void Increment()
        {
            Count++;
            NotifyObserver(Count);
        }
        public void Decrement()
        {
            Count--;
            NotifyObserver(Count);
        }

        public void NotifyObserver(int Count)
        {
            foreach (IObserver ob in observers)
            {
                ob.Update(Count);

            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

    }
}
