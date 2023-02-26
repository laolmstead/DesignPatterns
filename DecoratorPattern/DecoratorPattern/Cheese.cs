using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Cheese : IBurger
    {
        private readonly IBurger _Burger;

        public Cheese(IBurger burger)
        {
            _Burger = burger;
            Cost = _Burger.Cost + 1.00;
            _Burger.Description.ForEach(x => Description.Add(x));
            Description.Add("cheese");
        }

        public List<string> Description { get; } = new List<string>();

        public double Cost { get; set; }
    }
}
