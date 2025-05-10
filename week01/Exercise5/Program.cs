using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // display the first function to the user
        //(the displaywelcomemessage function) is called
        DisplayWelcomeMessage();


        //Asks the user for their name
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        PromptUserName(userName);


        //Asks the user for the number
        Console.WriteLine("Please enter a number:");
        string userNumber = Convert.ToString(Console.ReadLine());
        PromptUserNumber(userNumber);


        //Asks the user for the number to square
        Console.WriteLine("Please enter a number to square:");
        string userSquareNumber = Console.ReadLine();
        int number = Convert.ToInt32(userSquareNumber);
        int squareNumberResults =SquareNumber(number);


        // displays the result of the square number and username
        DisplayResult(userName, squareNumberResults);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void PromptUserName (string userName)
    {
        Console.WriteLine($"the username is {userName}");
    }
    static void PromptUserNumber(string userNumber) 
    {   int number = Convert.ToInt32(userNumber);
        Console.WriteLine($"the number is {number}");
    }
    static int SquareNumber(int number)
    {int SquareNumber = number * number;
        return SquareNumber;
    }
    static void DisplayResult(string userName, int SquareNumber)
    {
        Console.WriteLine($"The square of {userName} is {SquareNumber}");
    }

}