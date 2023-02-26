using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DoubleBurger : IBurger
    {
        public DoubleBurger()
        {
            Description.Add("Double bacon burger");
            Cost = 4.50;
        }

        public List<string> Description { get; } = new List<string>();
        public double Cost { get; set; }
    }
}
