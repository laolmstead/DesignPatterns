using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class FederalTaxes
    {
        public int Calculate()
        {
            int taxes = RandomNumberGenerator.GetInt32(1000, 10000);
            Console.WriteLine($"Totalling federal tax amount... {taxes}");
            return taxes;
        }
    }
}
