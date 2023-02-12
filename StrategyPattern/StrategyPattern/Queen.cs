using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Queen : Character
    {
        public Queen()
        {
            Weapon = new BowAndArrowBehavior();
            Defense = new DodgeBehavior();
            Name = "Queen";
            Points = 80;
        }
    }
}
