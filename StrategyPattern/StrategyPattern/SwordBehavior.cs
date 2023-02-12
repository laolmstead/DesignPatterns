using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SwordBehavior : IWeaponBehavior
    {
        public int UseWeapon()
        {
            Console.WriteLine("Stabbed by sword attack!");
            return RandomNumberGenerator.GetInt32(8, 11);
        }
    }
}
