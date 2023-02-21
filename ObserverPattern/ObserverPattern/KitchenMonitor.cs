using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class KitchenMonitor : IObservable<Order>
    {
        private List<IObserver<Order>> _Observers;

        public KitchenMonitor()
        {
            _Observers = new List<IObserver<Order>>();
        }

        public IDisposable Subscribe(IObserver<Order> observer)
        {
            if (!_Observers.Contains(observer))
                _Observers.Add(observer);

            return new Unsubscriber(_Observers, observer);
        }

        public void GetOrder()
        {
            List<string> cooks = new List<string>()
            { 
                new string("Karen"),
                new string("Sam"),
                new string("Barty"),
                new string("Iris"),
                new string("Pat")
            };

            for (int i = 0; i < 1000; i++)
            {
                int orderNum = RandomNumberGenerator.GetInt32(100000, 999999);
                string cookName = cooks[RandomNumberGenerator.GetInt32(0, cooks.Count)];
                Order order = new Order(orderNum, cookName, DateTime.Now);

                foreach (IObserver<Order> observer in _Observers)
                {
                    observer.OnNext(order);
                }
            }

            foreach (IObserver<Order> observer in _Observers)
            {
                observer.OnCompleted();
            }

            _Observers.Clear();
        }
    }
}
