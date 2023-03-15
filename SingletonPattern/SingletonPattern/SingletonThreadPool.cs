using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonThreadPool
    {
        private static SingletonThreadPool? _instance = null;
        private IList<SingletonThread> _threads = new List<SingletonThread>();
        private static object _lock = new object();

        private SingletonThreadPool() 
        {
            // Create 5 threads for the pool
            SingletonThread thread1 = new SingletonThread();
            thread1.ThreadId = 1;
            thread1.State = ThreadStateType.New;
            _threads.Add(thread1);

            SingletonThread thread2 = new SingletonThread();
            thread2.ThreadId = 2;
            thread2.State = ThreadStateType.New;
            _threads.Add(thread2);

            SingletonThread thread3 = new SingletonThread();
            thread3.ThreadId = 3;
            thread3.State = ThreadStateType.New;
            _threads.Add(thread3);

            SingletonThread thread4 = new SingletonThread();
            thread4.ThreadId = 4;
            thread4.State = ThreadStateType.New;
            _threads.Add(thread4);

            SingletonThread thread5 = new SingletonThread();
            thread5.ThreadId = 5;
            thread5.State = ThreadStateType.New;
            _threads.Add(thread5);
        }

        public static SingletonThreadPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance = new SingletonThreadPool();
                    }
                }

                return _instance;
            }
        }

        public SingletonThread GetThread()
        {
            while (true)
            {
                UpdateThreadState();

                foreach (SingletonThread thread in _threads)
                {
                    if (thread.State == ThreadStateType.New || thread.State == ThreadStateType.Terminated)
                    {
                        return thread;
                    }
                }

                Console.WriteLine("No threads available. Waiting...");
                Thread.Sleep(2000);
            }
        }

        private void UpdateThreadState()
        {
            int position = RandomNumberGenerator.GetInt32(0, 5);
            SingletonThread thread = _threads[position];
            thread.State = (ThreadStateType)RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine($"Thread {thread.ThreadId} state updated to {thread.State}!");
        }
    }
}
