using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Troll : Character
    {
        public Troll()
        {
            Weapon = new AxeBehavior();
            Defense = new ShieldBehavior();
            Name = "Troll";
            Points = 30;
        }
    }
}
