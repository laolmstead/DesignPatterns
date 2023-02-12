using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public static class RandomNumberHelper
    {
        public static int GetRandomInt(int min, int max)
        {
            return RandomNumberGenerator.GetInt32(min, max + 1);
        }
    }
}
