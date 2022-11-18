using CoffeeShop.Enums;
using CoffeeShop.Factories;

var regularCoffee = CoffeeFactory.GetCoffee(CoffeeType.Regular);
Console.WriteLine(regularCoffee.Name);
Console.WriteLine(regularCoffee.CoffeeContent);
Console.WriteLine(regularCoffee.MilkContent);