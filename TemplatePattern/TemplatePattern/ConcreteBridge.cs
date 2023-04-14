using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class ConcreteBridge : Bridge
    {
        public override void Superstructure()
        {
            Console.WriteLine("Constructing concrete superstructure...");
        }

        public override void Deck()
        {
            base.Deck();

            Console.WriteLine("Constructing concrete deck...");
        }
    }
}
