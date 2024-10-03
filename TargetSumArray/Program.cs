namespace TargetSumArray;

public class Program()
{
    public static void Main()
    {
        var example1 = FinderElement.Search([3, 2, 4], 3);
        var example2 = FinderElement.Search([1, 2, 3], 4);
        var example3 = FinderElement.Search([1], 2);
        var example4 = FinderElement.Search([1,2,3,4,5,6,5,9], 10);

        Console.WriteLine(example1);
        Console.WriteLine(example2);
        Console.WriteLine(example3);
        Console.WriteLine(example4);
    }
}