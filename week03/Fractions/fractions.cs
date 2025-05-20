using System;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{
    private int _numerator;
    private int _denominator;

    // creating a constructor which takes no parameters
    public Fractions()
    {
        _numerator = 1;
        _denominator = 1; // default denominator to avoid division by zero
    }
    // creating a constructor which takes in parameter for the numerator and non for the denominator
    public Fractions(int numerator)
    {
        _numerator = numerator;
        _denominator = 1; // default denominator to avoid division by zero
    }
    // creating a constructor which takes in parameters for the numerator and denominator
    public Fractions(int numerator, int denominator)
    {

        _numerator = numerator;
        _denominator = denominator;
        if (_denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        if (_numerator == 0)
        {
            _denominator = 1; // default denominator to avoid division by zero
        }






    }
    // creating the getters and setters for the numerator
    public int getNumerator()
    {
        return _numerator;
    }
    public void setNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int getDenominator()
    {
        return _denominator;
    }



    public void setDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // creating a method to represent the numerator and denominator as a fraction
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // creating a method to represent the fraction as a decimal

    public string GetDecimalValue()
    {
        double result = ((double)_numerator) / (_denominator);
        return result.ToString();

    }

}