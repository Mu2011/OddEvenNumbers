

namespace OddEvenNumbersApp;

public class Program
{
    private static void Main(string[] args)
    {
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        PrintNumbers("Numbers", Numbers);
        PrintNumbers("Even No", Numbers.Where(IsEven));
        PrintNumbers("Odd No", Numbers.Where(IsOdd));
        
        Console.ReadKey();
    }
    static void PrintNumbers(string title, IEnumerable<int> numbers)
    {
        Console.WriteLine();
        Console.Write($"{title}: [");
        
        foreach (var n in numbers)
            Console.Write($" {n}");

        Console.Write($" ]");
        Console.WriteLine();
    }
    static bool IsEven(int number) => number % 2 == 0;
    
    static bool IsOdd(int number) => !IsEven(number);
}