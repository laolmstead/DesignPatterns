using EventsObserverPattern;

KitchenMonitor kitchenMonitor = new KitchenMonitor();

Server1 server1 = new Server1(kitchenMonitor);
Server2 server2 = new Server2(kitchenMonitor);

kitchenMonitor.UpdateOrders();

Console.ReadKey();
