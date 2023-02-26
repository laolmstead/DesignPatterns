using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IBurger
    {
        List<string> Description { get; }
        double Cost { get; set; }
    }
}
