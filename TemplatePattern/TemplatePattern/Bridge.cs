using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class Bridge
    {
        public void Construct()
        {
            Foundation();

            Substructure();

            Superstructure();

            Deck();
        }

        public void Foundation()
        {
            Console.WriteLine("Laying foundation...");
        }

        public void Substructure()
        {
            Console.WriteLine("Building substructure...");
        }

        public abstract void Superstructure();

        public virtual void Deck()
        {

        }
    }
}
