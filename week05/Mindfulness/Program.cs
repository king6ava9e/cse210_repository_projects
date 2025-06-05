using System;



class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            // Show the main menu
            if (!Console.IsOutputRedirected)
                Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read and parse the user's input
            string input = Console.ReadLine();
            int.TryParse(input, out choice);

            if (!Console.IsOutputRedirected)
                Console.Clear();

            if (choice == 1)
            {
                // Breathing activity
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == 2)
            {
                // Listing activity
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == 3)
            {
                // Reflecting activity
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == 4)
            {
                // Exit
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                // Invalid input
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
            }

            if (choice != 4)
            {
                // Pause before showing the menu again
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}