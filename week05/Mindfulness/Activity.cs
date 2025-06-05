using System;
using System.Threading;

public class Activity
{
    // Private fields to store activity data
    private string _name;
    private string _description;
    private int _duration;

    // Constructor: sets initial values for an activity
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Getter for _name
    public string GetName()
    {
        return _name;
    }

    // Setter for _name
    public void SetName(string name)
    {
        _name = name;
    }

    // Getter for _description
    public string GetDescription()
    {
        return _description;
    }

    // Setter for _description
    public void SetDescription(string description)
    {
        _description = description;
    }

    // Getter for _duration
    public int GetDuration()
    {
        return _duration;
    }

    // Setter for _duration
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Display the starting message
    public void DisplayStartingMessage()
    {
        if (!Console.IsOutputRedirected)
            Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);  // Spinner for 3 seconds
    }

    // Display the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    // Spinner animation (used for small pauses)
    public void ShowSpinner(int seconds)
    {
        string[] spinnerChars = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(250);
            Console.Write("\b");
            i = (i + 1) % spinnerChars.Length;
        }
    }

    // Countdown timer from a number of seconds
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}