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
        private Stack<ICommand> _UndoCommands = new Stack<ICommand>();

        public void SetOperation(ICommand command)
        {
            _Commands.Enqueue(command);
        }

        public void ExecuteOperation()
        {
            ICommand command = _Commands.Dequeue();
            _UndoCommands.Push(command);

            command.Execute();
        }

        public void UndoOperation()
        {
            ICommand command = _UndoCommands.Pop();
            command.Undo();
        }

        public int CommandCount { get { return _Commands.Count; } }
        public int UndoCommandCount { get { return _UndoCommands.Count; } }
    }
}
