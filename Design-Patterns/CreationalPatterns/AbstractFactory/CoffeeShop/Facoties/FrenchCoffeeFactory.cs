using CoffeeShop.AbstractProductModels;
using CoffeeShop.ProductModels;

namespace CoffeeShop.Facoties;

public class FrenchCoffeeFactory : CoffeeFactory
{
    public override MilkCoffee GetMilkCoffee()
    {
        return new Macchiato();
    }

    public override PlainCoffee GetPlainCoffee()
    {
        return new RegularCoffee();
    }
}
