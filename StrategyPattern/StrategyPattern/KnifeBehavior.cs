using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public int UseWeapon()
        {
            Console.WriteLine("Stabbed by knife attack!");
            return RandomNumberGenerator.GetInt32(1, 4);
        }
    }
}