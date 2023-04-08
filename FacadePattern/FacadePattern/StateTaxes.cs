using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class StateTaxes
    {
        public int Calculate()
        {
            int taxes = RandomNumberGenerator.GetInt32(100, 1000);
            Console.WriteLine($"Totalling state tax amount... {taxes}");
            return taxes;
        }
    }
}
