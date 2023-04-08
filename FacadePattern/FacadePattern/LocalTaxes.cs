using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class LocalTaxes
    {
        public int Calculate()
        {
            int taxes = RandomNumberGenerator.GetInt32(10, 100);
            Console.WriteLine($"Totalling local tax amount... {taxes}");
            return taxes;
        }
    }
}
