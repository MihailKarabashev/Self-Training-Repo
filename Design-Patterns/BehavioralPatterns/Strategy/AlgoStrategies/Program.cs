using AlgoStrategies.Models;

var bogoClient = new Client(new BogoSort());
bogoClient.ContextInterface();

var quickSortClient = new Client(new QuickSort());
quickSortClient.ContextInterface();

var mergeSortClient = new Client(new MergeSort());
mergeSortClient.ContextInterface();