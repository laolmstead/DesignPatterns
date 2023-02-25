using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsObserverPattern
{
    public class Server2
    {
        public Server2(KitchenMonitor kitchenMonitor)
        {
            kitchenMonitor.OrderCompleteEventHandler += KitchenMonitor_OrderCompleteEventHandler;
        }

        public string Name { get { return "Server 2"; } }

        private void KitchenMonitor_OrderCompleteEventHandler(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"{this.Name} received update on {e.OrderNumber} from {e.CookName} at {e.Date.ToString("F")} too.");
        }
    }
}
