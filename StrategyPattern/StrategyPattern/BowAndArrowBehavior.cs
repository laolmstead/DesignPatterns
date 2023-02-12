using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public int UseWeapon()
        {
            Console.WriteLine("Shot by bow and arrow attack!");
            return RandomNumberGenerator.GetInt32(7, 10);
        }
    }
}
