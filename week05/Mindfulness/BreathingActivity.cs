using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // No private fields are needed here for now

    // Constructor: sets up name, description, and default duration
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
        30) // default 30 seconds
    {
        // No extra setup needed for now
    }

    // Main method that runs the breathing activity
    public void Run()
    {
        // First, show the starting message
        DisplayStartingMessage();

        Console.WriteLine(); // Add some spacing

        // Get how long the activity should last
        int duration = GetDuration();

        // Figure out when to stop the breathing activity
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Keep looping until the time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);  // Count down for 4 seconds

            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountDown(6);  // Count down for 6 seconds

            Console.WriteLine();
            Console.WriteLine(); // Add an extra line between breaths
        }

        // Show the ending message
        DisplayEndingMessage();
    }
}
