using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeFile : IComponent
    {
        public CompositeFile(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
