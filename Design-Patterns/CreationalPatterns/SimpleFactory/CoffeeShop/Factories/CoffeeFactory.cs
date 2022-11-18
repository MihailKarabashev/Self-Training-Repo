using CoffeeShop.Enums;
using CoffeeShop.Models;

namespace CoffeeShop.Factories
{
    public static class CoffeeFactory
    {
        public static Coffe GetCoffee(CoffeeType coffeeType)
        {
            switch (coffeeType)
            {
                case CoffeeType.Regular:
                    return new RegularCoffee();
                case CoffeeType.Double:
                    return new DoubleCoffee();
                case CoffeeType.Cappuccino:
                    return new Cappuccino();
                case CoffeeType.Macchiato:
                    return new Macchiato();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
