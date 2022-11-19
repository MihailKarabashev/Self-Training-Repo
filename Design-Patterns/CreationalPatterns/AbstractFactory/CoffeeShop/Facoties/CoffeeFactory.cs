using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.Facoties;

public abstract class CoffeeFactory
{
    public abstract MilkCoffee GetMilkCoffee();

    public abstract PlainCoffee GetPlainCoffee(); 
}
