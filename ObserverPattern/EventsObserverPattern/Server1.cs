using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsObserverPattern
{
    public class Server1
    {
        public Server1 (KitchenMonitor kitchenMonitor) 
        {
            kitchenMonitor.OrderCompleteEventHandler += KitchenMonitor_OrderCompleteEventHandler;
        }

        public string Name { get { return "Server 1"; } }

        private void KitchenMonitor_OrderCompleteEventHandler(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"{this.Name} received update on {e.OrderNumber} from {e.CookName} at {e.Date.ToString("F")}.");
        }
    }
}
