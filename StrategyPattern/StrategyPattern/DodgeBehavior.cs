using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DodgeBehavior : IDefenseBehavior
    {
        public int UseDefense()
        {
            Console.WriteLine("Dodged attack!");
            return RandomNumberGenerator.GetInt32(1, 10);
        }
    }
}
