using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class PcComputer : IComputer
    {
        public PcComputer(string name, double price, double rating) 
        { 
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
    }
}
