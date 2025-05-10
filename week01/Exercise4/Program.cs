using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a number please.(type 0 to exit)");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        while (number != 0)
        {
            numbers.Add(number);

            input = Console.ReadLine();
            number = Convert.ToInt32(input);
        }

        int Sum = numbers.Sum();
        double Average = numbers.Average();
        int Max = numbers.Max();
        Console.WriteLine($"Sum: {Sum}");
        Console.WriteLine($"Average: {Average}");
        Console.WriteLine($"Max: {Max}");
    }
}