using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Onion : IBurger
    {
        private readonly IBurger _Burger;

        public Onion(IBurger burger)
        {
            _Burger = burger;
            Cost = _Burger.Cost + 0.15;
            _Burger.Description.ForEach(x => Description.Add(x));
            Description.Add("onion");
        }

        public List<string> Description { get; } = new List<string>();

        public double Cost { get; set; }
    }
}
