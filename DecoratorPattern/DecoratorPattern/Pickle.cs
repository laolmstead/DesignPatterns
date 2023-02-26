using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Pickle : IBurger
    {
        private readonly IBurger _Burger;

        public Pickle(IBurger burger)
        {
            _Burger = burger;
            Cost = _Burger.Cost + 0.05;
            _Burger.Description.ForEach(x => Description.Add(x));
            Description.Add("pickles");
        }

        public List<string> Description { get; } = new List<string>();

        public double Cost { get; set; }
    }
}
