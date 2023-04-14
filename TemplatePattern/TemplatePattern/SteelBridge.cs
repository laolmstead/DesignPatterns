using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class SteelBridge : Bridge
    {
        public override void Superstructure()
        {
            Console.WriteLine("Constructing steel superstructure...");
        }
    }
}
