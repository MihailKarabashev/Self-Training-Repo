using CoffeeShop.AbstractProductModels;
using CoffeeShop.ProductModels;

namespace CoffeeShop.Facoties;

public class ItalianCoffeeFactory : CoffeeFactory
{
    public override MilkCoffee GetMilkCoffee()
    {
        return new Cappuccino();
    }

    public override PlainCoffee GetPlainCoffee()
    {
        return new DoubleCoffee();
    }
}
