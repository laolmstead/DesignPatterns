﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Knight : Character
    {
        public Knight() 
        {
            Weapon = new SwordBehavior();
            Defense = new ArmorBehavior();
            Name = "Knight";
            Points = 40;
        }
    }
}
