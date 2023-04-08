using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DivideValueCommand : ICommand
    {
        private DivideValue _DivideValue;

        public DivideValueCommand(DivideValue divideValue)
        {
            _DivideValue = divideValue;
        }

        public void Execute()
        {
            _DivideValue.Divide();
        }
    }
}
