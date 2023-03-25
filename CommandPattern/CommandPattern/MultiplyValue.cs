using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MultiplyValue
    {
        private double _MultipliedValue;
        private double _StartingValue;
        private double _EndingValue;

        public MultiplyValue(double startingValue, double multipliedValue)
        {
            _MultipliedValue = multipliedValue;
            _StartingValue = startingValue;
            _EndingValue = startingValue;
        }

        public void Multiply()
        {
            _EndingValue = _StartingValue * _MultipliedValue;
            Console.WriteLine($"Multiplying... {_StartingValue} * {_MultipliedValue} = {_EndingValue}");
        }

        public void Undo()
        {
            _EndingValue = _StartingValue;

            Console.WriteLine("Undoing multiply...");
            Console.WriteLine($"Current value = {_EndingValue}");
        }
    }
}
