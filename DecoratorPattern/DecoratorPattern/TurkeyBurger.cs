using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class TurkeyBurger : IBurger
    {
        public TurkeyBurger()
        {
            Description.Add("Turkey burger");
            Cost = 2.25;
        }

        public List<string> Description { get; } = new List<string>();
        public double Cost { get; set; }
    }
}
