using System;

class Program
{
    static void Main(string[] args)
    // creating an instance of the class
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(3);
        Fractions fraction3 = new Fractions(3, 4);

        /*  Fractions fractions1 = new Fractions();
          fraction1.getDenominator();
          Console.WriteLine(fraction1.getNumerator());

          Fractions fractions4 = new Fractions();
          fraction1.setNumerator(2);
          Console.WriteLine(fraction1.getNumerator()); */
        
        // Create using default constructor (should be 1/1 or whatever your default is)
Fractions f1 = new Fractions(8,7);
Console.WriteLine("Fraction 1:");
Console.WriteLine($"Numerator: {f1.getNumerator()}");
Console.WriteLine($"Denominator: {f1.getDenominator()}");
Console.WriteLine($"Fraction String: {f1.GetFractionString()}");
Console.WriteLine($"Decimal Value: {f1.GetDecimalValue()}");
Console.WriteLine();
        
    }
}