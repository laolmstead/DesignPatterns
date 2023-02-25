using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EventsObserverPattern
{
    public class KitchenMonitor
    {
        public event EventHandler<OrderEventArgs> OrderCompleteEventHandler;

        public void UpdateOrders()
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
                OnOrderComplete(orderNum, cookName, DateTime.Now);
            }
        }

        private void OnOrderComplete(int orderNum, string cookName, DateTime date)
        {
            OrderEventArgs orderEventArgs = new OrderEventArgs(orderNum, cookName, date);

            OrderCompleteEventHandler?.Invoke(this, orderEventArgs);
        }
    }
}
