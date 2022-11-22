namespace AlgoStrategies.Models;

public class MergeSort : AbstractStrategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"Called from {GetType().Name}");
    }
}
