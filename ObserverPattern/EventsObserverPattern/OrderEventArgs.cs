using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsObserverPattern
{
    public class OrderEventArgs : EventArgs
    {
        public OrderEventArgs(int orderNumber, string cookName, DateTime date)
        {
            OrderNumber = orderNumber;
            CookName = cookName;
            Date = date;
        }

        public int OrderNumber { get; }

        public string CookName { get; }

        public DateTime Date { get; }
    }
}
