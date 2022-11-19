using CoffeeShop.AbstractProductModels;
using Microsoft.VisualBasic;

namespace CoffeeShop.ProductModels;

public class RegularCoffee : PlainCoffee
{
    public override string Name => "RegularCoffee";

    public override int CoffeeContent => 100;

    public override int MilkContent => 0;
}
