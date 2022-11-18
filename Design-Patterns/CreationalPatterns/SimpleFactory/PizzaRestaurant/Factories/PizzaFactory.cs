using PizzaRestaurant.Enums;
using PizzaRestaurant.Models;

namespace PizzaRestaurant.Factories;

public class PizzaFactory
{
    public static Pizza CreatePizza(PizzaType pizzaType)
    {
        return pizzaType switch
        {
            PizzaType.Pepperoni => new PepperoniPizza(),
            PizzaType.Hawai => new HawaiPizza(),
            PizzaType.Cheese => new CheesePizza(),
            _ => throw new ArgumentException()
        };
    }
}
