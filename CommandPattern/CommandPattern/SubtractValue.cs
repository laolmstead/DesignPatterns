using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SubtractValue
    {
        private double _SubtractedValue;
        private double _StartingValue;
        private double _EndingValue;

        public SubtractValue(double startingValue, double subtractedValue)
        {
            _SubtractedValue = subtractedValue;
            _StartingValue = startingValue;
            _EndingValue = startingValue;
        }

        public void Subtract()
        {
            _EndingValue = _StartingValue - _SubtractedValue;
            Console.WriteLine($"Subtracting... {_StartingValue} - {_SubtractedValue} = {_EndingValue}");
        }
    }
}
