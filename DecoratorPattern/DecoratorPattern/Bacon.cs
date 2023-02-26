using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Bacon : IBurger
    {
        private readonly IBurger _Burger;

        public Bacon(IBurger burger)
        {
            _Burger = burger;
            Cost = _Burger.Cost + 1.50;
            _Burger.Description.ForEach(x => Description.Add(x));
            Description.Add("bacon");
        }

        public List<string> Description { get; } = new List<string>();

        public double Cost { get; set; }
    }
}
