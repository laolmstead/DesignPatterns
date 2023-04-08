using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AddValue
    {
        private double _AddedValue;
        private double _StartingValue;
        private double _EndingValue;

        public AddValue(double startingValue, double addedValue)
        {
            _AddedValue = addedValue;
            _StartingValue = startingValue;
            _EndingValue = startingValue;
        }

        public void Add()
        {
            _EndingValue = _StartingValue + _AddedValue;
            Console.WriteLine($"Adding... {_StartingValue} + {_AddedValue} = {_EndingValue}");
        }
    }
}
