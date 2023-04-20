using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal interface IComputer
    {
        string Name { get; set; }
        double Price { get; set; }
        double Rating { get; set;}
    }
}
