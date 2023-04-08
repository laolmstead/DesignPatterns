using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Taxes
    {
        public void Calculate()
        {
            int total = 0;

            FederalTaxes federalTaxes = new FederalTaxes();
            total += federalTaxes.Calculate();

            StateTaxes stateTaxes = new StateTaxes();
            total += stateTaxes.Calculate();

            LocalTaxes localTaxes = new LocalTaxes();
            total += localTaxes.Calculate();

            Console.Write($"Total taxes owed: {total}");
        }
    }
}
