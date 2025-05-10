using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("what is your grade percentage? ");
        string score = Console.ReadLine();
        string letter;
        int grade = Convert.ToInt32(score);
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (score.Length > 1)
        {
            int secondDigit = int.Parse(score[1].ToString());

            if (secondDigit >= 7)
            {
                letter += "+";
            }
            else if (secondDigit <= 3)
            {
                letter += "-";
            }
            else
            {
                letter += "";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {letter} and a score of {grade}.");
        }
    }
}