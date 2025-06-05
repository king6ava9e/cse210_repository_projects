using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    // Private fields specific to listing
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity() : base("Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
        30) // default duration is 30 seconds
    {
        // Initialize the list of prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0; // Start count at 0
    }

    // Getter and setter for _count
    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int value)
    {
        _count = value;
    }

    // Run method to start the activity
    public void Run()
    {
        // Show intro
        DisplayStartingMessage();
        Console.WriteLine();

        // Get how long we should run this activity
        int duration = GetDuration();

        // Get a random prompt
        string prompt = GetRandomPrompt();

        // Display the prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Give the user 5 seconds before starting

        Console.WriteLine();

        // Track the end time
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Create a list to store the responses
        List<string> responses = GetListFromUser(endTime);

        // Update the count field
        _count = responses.Count;

        // Show how many items the user entered
        Console.WriteLine($"You listed {_count} items.");

        // Wrap up
        DisplayEndingMessage();
    }

    // Get a random prompt from the list
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    // Get list of responses from the user until time is up
    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input.Trim());
            }
        }

        return responses;
    }
}
