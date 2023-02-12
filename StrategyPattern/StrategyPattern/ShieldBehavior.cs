using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShieldBehavior : IDefenseBehavior
    {
        public int UseDefense()
        {
            Console.WriteLine("Blunted damage with sheild!");
            return RandomNumberGenerator.GetInt32(2, 5);
        }
    }
}
