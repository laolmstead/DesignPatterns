using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Tomato : IBurger
    {
        private readonly IBurger _Burger;

        public Tomato(IBurger burger)
        {
            _Burger = burger;
            Cost = _Burger.Cost + 0.12;
            _Burger.Description.ForEach(x => Description.Add(x));
            Description.Add("tomato");
        }

        public List<string> Description { get; } = new List<string>();

        public double Cost { get; set; }
    }
}
