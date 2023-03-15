using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public enum ThreadStateType
    {
        New = 1,
        Running = 2,
        Blocked = 3,
        Waiting = 4,
        TimedWaiting = 5,
        Terminated = 6
    }
}
