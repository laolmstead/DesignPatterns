using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Calculator
    {
        private Queue<ICommand> _Commands = new Queue<ICommand>();

        public void SetOperation(ICommand command)
        {
            _Commands.Enqueue(command);
        }

        public void ExecuteOperation()
        {
            ICommand command = _Commands.Dequeue();

            command.Execute();
        }

        public int CommandCount { get { return _Commands.Count; } }
    }
}
