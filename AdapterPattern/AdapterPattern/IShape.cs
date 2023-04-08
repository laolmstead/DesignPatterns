using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IShape
    {
        public string Name { get; }
        public double Area { get; }
    }
}
