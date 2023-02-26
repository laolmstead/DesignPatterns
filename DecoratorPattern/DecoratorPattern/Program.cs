// Loaded bacon double burger
using DecoratorPattern;
using System.Text;

DoubleBurger doubleBurger = new DoubleBurger();
Bacon bacon = new Bacon(doubleBurger);
Cheese cheese = new Cheese(bacon);
Ketchup ketchup = new Ketchup(cheese);
Lettuce lettuce = new Lettuce(ketchup);
Mayonaise mayo = new Mayonaise(lettuce);
Mustard mustard = new Mustard(mayo);
Onion onion = new Onion(mustard);
Pickle pickle = new Pickle(onion);
Tomato tomato = new Tomato(pickle);

StringBuilder sb = new StringBuilder();
for (int i = 0; i < tomato.Description.Count - 1; i++)
{
    string desc = tomato.Description[i];
    sb.Append($"{desc}, ");
}

sb.Append(tomato.Description.LastOrDefault());

Console.WriteLine($"{sb} - ${tomato.Cost.ToString("0.00")}");

// Angus beef cheese burger
AngusBeefBurger angusBeefBurger = new AngusBeefBurger();
cheese = new Cheese(angusBeefBurger);
ketchup = new Ketchup(cheese);
lettuce = new Lettuce(ketchup);
mayo = new Mayonaise(lettuce);
mustard = new Mustard(mayo);
pickle = new Pickle(mustard);
tomato = new Tomato(pickle);

sb = new StringBuilder();
for (int i = 0; i < tomato.Description.Count - 1; i++)
{
    string desc = tomato.Description[i];
    sb.Append($"{desc}, ");
}

sb.Append(tomato.Description.LastOrDefault());

Console.WriteLine($"{sb} - ${tomato.Cost.ToString("0.00")}");


TurkeyBurger turkeyBurger = new TurkeyBurger();
ketchup = new Ketchup(turkeyBurger);
lettuce = new Lettuce(ketchup);
mustard = new Mustard(lettuce);
onion = new Onion(mustard);
pickle = new Pickle(onion);
tomato = new Tomato(pickle);

sb = new StringBuilder();
for (int i = 0; i < tomato.Description.Count - 1; i++)
{
    string desc = tomato.Description[i];
    sb.Append($"{desc}, ");
}

sb.Append(tomato.Description.LastOrDefault());

Console.WriteLine($"{sb} - ${tomato.Cost.ToString("0.00")}");

// Impossible cheese burger
ImpossibleBurger impossibleBurger = new ImpossibleBurger();
cheese = new Cheese(impossibleBurger);
lettuce = new Lettuce(cheese);
mayo = new Mayonaise(lettuce);
mustard = new Mustard(mayo);
onion = new Onion(mustard);
pickle = new Pickle(onion);
tomato = new Tomato(pickle);

sb = new StringBuilder();
for (int i = 0; i < tomato.Description.Count - 1; i++)
{
    string desc = tomato.Description[i];
    sb.Append($"{desc}, ");
}

sb.Append(tomato.Description.LastOrDefault());

Console.WriteLine($"{sb} - ${tomato.Cost.ToString("0.00")}");
