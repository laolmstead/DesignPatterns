using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class King : Character
    {
        public King() 
        {
            Weapon = new KnifeBehavior();
            Defense = new DeflectBehavior();
            Name = "King";
            Points = 100;
        }
    }
}
