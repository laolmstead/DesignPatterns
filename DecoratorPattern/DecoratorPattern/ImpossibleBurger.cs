using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ImpossibleBurger : IBurger
    {
        public ImpossibleBurger()
        {
            Description.Add("Impossible burger");
            Cost = 3.25;
        }

        public List<string> Description { get; } = new List<string>();
        public double Cost { get; set; }
    }
}
