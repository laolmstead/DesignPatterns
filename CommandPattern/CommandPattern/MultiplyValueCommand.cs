using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MultiplyValueCommand : ICommand
    {
        private MultiplyValue _MultiplyValue;

        public MultiplyValueCommand(MultiplyValue multiplyValue)
        {
            _MultiplyValue = multiplyValue;
        }

        public void Execute()
        {
            _MultiplyValue.Multiply();
        }

        public void Undo()
        {
            _MultiplyValue.Undo();
        }
    }
}
