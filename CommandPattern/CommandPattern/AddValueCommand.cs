using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AddValueCommand : ICommand
    {
        private AddValue _AddValue;

        public AddValueCommand(AddValue addValues)
        {
            _AddValue = addValues;
        }

        public void Execute()
        {
            _AddValue.Add();
        }
    }
}
