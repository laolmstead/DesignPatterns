using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AxeBehavior : IWeaponBehavior
    {
        public int UseWeapon()
        {
            Console.WriteLine("Axe attack!");
            return RandomNumberGenerator.GetInt32(3, 6);
        }
    }
}
