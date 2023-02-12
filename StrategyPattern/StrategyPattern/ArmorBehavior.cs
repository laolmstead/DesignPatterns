using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ArmorBehavior : IDefenseBehavior
    {
        public int UseDefense()
        {
            Console.WriteLine("Attack blunted by armor!");
            return RandomNumberGenerator.GetInt32(1, 4);
        }
    }
}
