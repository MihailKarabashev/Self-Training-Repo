using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.ProductModels;

public class Macchiato : MilkCoffee
{
    public override string Name => "Macchiato";

    public override int CoffeeContent => 100;

    public override int MilkContent => 100;
}
