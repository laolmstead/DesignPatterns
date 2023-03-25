﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DivideValue
    {
        private double _DividedValue;
        private double _StartingValue;
        private double _EndingValue;

        public DivideValue(double startingValue, double dividedValue)
        {
            _DividedValue = dividedValue;
            _StartingValue = startingValue;
            _EndingValue = startingValue;
        }

        public void Divide()
        {
            try
            {
                _EndingValue = _StartingValue / _DividedValue;
                Console.WriteLine($"Dividing... {_StartingValue} / {_DividedValue} = {_EndingValue}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Error: Unable to divide by 0!");
            }
        }

        public void Undo()
        {
            if (_DividedValue == 0)
            {
                Console.WriteLine("Skipping invalid dividing by 0 operation...");
            }

            _EndingValue = _StartingValue;

            Console.WriteLine("Undoing divide...");
            Console.WriteLine($"Current value = {_EndingValue}");
        }
    }
}
