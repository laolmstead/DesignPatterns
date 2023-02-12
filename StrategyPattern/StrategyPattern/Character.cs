using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Character
    {
        public Character() 
        {
            
        }

        public IWeaponBehavior? Weapon { get; set; }

        public IDefenseBehavior? Defense { get; set; }

        public string? Name { get; set; }

        public int? Points { get; set; }

        public int? Fight()
        {
            return Weapon?.UseWeapon();
        }

        public int? Defend()
        {
            return Defense?.UseDefense();
        }
    }
}
