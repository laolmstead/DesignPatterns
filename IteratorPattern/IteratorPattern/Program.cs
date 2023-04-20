using IteratorPattern;

ComputerList<IComputer> computerList = new ComputerList<IComputer>();

MacComputer macbookAir = new MacComputer("MacBook Air", 2999.99, 4.3);
computerList.Add(macbookAir);

MacComputer macbookPro = new MacComputer("MacBook Pro", 3999.99, 4.6);
computerList.Add(macbookPro);

PcComputer dellComputer = new PcComputer("Dell G7", 1389.50, 4.7);
computerList.Add(dellComputer);

PcComputer hpComputer = new PcComputer("HP Pavilion", 649.99, 4.1);
computerList.Add(hpComputer);

ChromeBookComputer chromeBookComputer = new ChromeBookComputer("Acer Chromebook Spin 714", 729.99, 4.2);
computerList.Add(chromeBookComputer);

Console.WriteLine("All computers");
foreach (IComputer computer in computerList)
{
    Console.WriteLine($"{computer.Name} - {computer.Price} (Rating: {computer.Rating}/5)");
}

Console.WriteLine();

Console.WriteLine("From cheapest to most expensive:");
foreach (IComputer computer in computerList.Cheapest)
{
    Console.WriteLine($"{computer.Name} - {computer.Price} (Rating: {computer.Rating}/5)");
}

Console.WriteLine();

Console.WriteLine("From highest to lowest rated:");
foreach (IComputer computer in computerList.HighestRated)
{
    Console.WriteLine($"{computer.Name} - {computer.Price} (Rating: {computer.Rating}/5)");
}