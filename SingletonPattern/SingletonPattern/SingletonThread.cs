using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonThread
    {
        public int ThreadId { get; set; } 
        public ThreadStateType State { get; set; }

        public string Name 
        { 
            get
            {
                return $"Thread {ThreadId} - State {State}";
            } 
        }
    }
}
