using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DeflectBehavior : IDefenseBehavior
    {
        public int UseDefense()
        {
            Console.WriteLine("Attack deflected!");
            return RandomNumberGenerator.GetInt32(5, 10);
        }
    }
}
