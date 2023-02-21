using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Server2 : IObserver<Order>
    {
        private IDisposable? unsubscriber;

        public virtual void Subscribe(IObservable<Order> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber?.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("No more orders for server 2.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(Order order)
        {
            Console.WriteLine($"Server 2 received update on order {order.OrderNumber} (chef {order.CookName} completed at {order.Date}.");
        }
    }
}
