using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SubtractValueCommand : ICommand
    {
        private SubtractValue _SubtractValue;

        public SubtractValueCommand(SubtractValue subtractValue)
        {
            _SubtractValue = subtractValue;
        }

        public void Execute()
        {
            _SubtractValue.Subtract();
        }
    }
}
