using SingletonPattern;

SingletonThreadPool threadPool = SingletonThreadPool.Instance;
SingletonThreadPool threadPool2 = SingletonThreadPool.Instance;
SingletonThreadPool threadPool3 = SingletonThreadPool.Instance;

if (threadPool == threadPool2 && threadPool2 == threadPool3)
{
    Console.WriteLine("Same instance of thread pool");
}

for (int i = 1; i < 500; i++)
{
    SingletonThread thread = threadPool.GetThread();
    Console.WriteLine($"{i + 1} - returned {thread.Name}!");
}
