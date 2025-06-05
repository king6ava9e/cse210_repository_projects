using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity() : base("Reflecting", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
        50) // default duration is 50 seconds
    {
        // Fill the prompt list
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Fill the questions list
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Getters and setters for _prompts
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    // Getters and setters for _questions
    public List<string> GetQuestions()
    {
        return _questions;
    }

    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }

    // Run the activity
    public void Run()
    {
        // Show intro
        DisplayStartingMessage();
        Console.WriteLine();

        // Get how long the activity will run
        int duration = GetDuration();
        int questionInterval = 10; // time per question
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Get a random prompt and show it
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        // Small pause before questions
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions related to this experience.");
        ShowSpinner(5); // Show spinner for 5 seconds before questions

        // Ask random questions until time is up
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            ShowSpinner(questionInterval);
        }

        // End
        DisplayEndingMessage();
    }

    // Get random prompt
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    // Get random question
    private string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    // Show the prompt nicely
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }

    // Show the question to ponder
    private void DisplayQuestion(string question)
    {
        Console.WriteLine();
        Console.WriteLine($"> {question}");
    }
}
