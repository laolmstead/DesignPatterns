using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class AngusBeefBurger : IBurger
    {
        public AngusBeefBurger()
        {
            Description.Add("100% Angus beef burger");
            Cost = 2.99;
        }

        public List<string> Description { get; } = new List<string>();
        public double Cost { get; set; }
    }
}
