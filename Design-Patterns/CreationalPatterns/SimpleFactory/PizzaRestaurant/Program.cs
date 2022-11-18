// See https://aka.ms/new-console-template for more information
using PizzaRestaurant.Enums;
using PizzaRestaurant.Factories;

Console.WriteLine("Hello, World!");


var pepperoniPizza = PizzaFactory.CreatePizza(PizzaType.Pepperoni);
var hawaiPizza = PizzaFactory.CreatePizza(PizzaType.Hawai);
var cheesePizza = PizzaFactory.CreatePizza(PizzaType.Cheese);


Console.WriteLine(pepperoniPizza.Description);
Console.WriteLine(hawaiPizza.Description);
Console.WriteLine(cheesePizza.Description);