using System;
using System.Collections.Generic;
using System.Threading;

namespace Design_Patterns.Behavioral.Observer
{
    public class Market : ISubject
    {
        private int _superRequiredProduct = 0;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void EnterSuperRequiredProduct(int amount)
        {
            Console.WriteLine("The Market receive new amount of the Required Product...");
            
            _superRequiredProduct += amount;
            
            Thread.Sleep(15);
            
            Notify();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Desattach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.ReceiveUpdate();
            }
        }
    }
}