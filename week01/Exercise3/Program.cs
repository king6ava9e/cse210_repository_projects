using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int number = random.Next(1, 101);

        Console.Write("Please enter a magic number: ");
        string input = Console.ReadLine();
        int guess = Convert.ToInt32(input);
        int attempts = 0;

        while (guess != number)
        {
            attempts++;

            // Provide feedback on the guess
            if (guess > number)
            {
                Console.WriteLine("Your guess is too high, guess lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low, guess higher.");
            }

            // Prompt the user for another guess
            Console.Write("Please enter a new guess: ");
            input = Console.ReadLine();
            guess = Convert.ToInt32(input);
        }

        Console.WriteLine("Congratulations! You guessed the magic number.");
        Console.WriteLine($"It took you {attempts} attempts to guess the number.");

        // Check if the user wants to play again
        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")
        {
            Main(args); // Restart the game
        }
        else
        {
            Console.WriteLine("Thank you for playing! Goodbye.");
        }
    }
}