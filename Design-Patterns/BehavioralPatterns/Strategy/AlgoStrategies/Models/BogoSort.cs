namespace AlgoStrategies.Models;

public class BogoSort : AbstractStrategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"Called from {GetType().Name}");
    }
}
