namespace AlgoStrategies.Models;

public class QuickSort : AbstractStrategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"Called from {GetType().Name}");
    }
}
