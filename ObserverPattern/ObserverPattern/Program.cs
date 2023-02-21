using ObserverPattern;

KitchenMonitor kitchen = new KitchenMonitor();

Server1 server1 = new Server1();
Server2 server2 = new Server2();

kitchen.Subscribe(server1);
kitchen.Subscribe(server2);

kitchen.GetOrder();

Console.ReadKey();

