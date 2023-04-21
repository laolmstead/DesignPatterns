using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeFolder : IComponent
    {
        public CompositeFolder(string name)
        {
            this.Name = name;
        }

        public IList<IComponent> Components { get; private set; } = new List<IComponent>();

        public string Name { get; set; }
    }
}
