
using CoffeeShop.Facoties;

CoffeeFactory italianCoffeeFactory = new ItalianCoffeeFactory();
var italianPlainCoffee =  italianCoffeeFactory.GetPlainCoffee();
var italianMilkCoffee = italianCoffeeFactory.GetMilkCoffee();

italianPlainCoffee.Print();
italianMilkCoffee.Print();

CoffeeFactory frenchCoffeeFactory = new FrenchCoffeeFactory();
var frenchPlainCoffee = frenchCoffeeFactory.GetPlainCoffee();
var frenchMilkCoffee = frenchCoffeeFactory.GetMilkCoffee();

frenchPlainCoffee.Print();
frenchMilkCoffee.Print();