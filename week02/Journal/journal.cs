using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public int _streak = 0;
    public DateTime? _lastEntryDate = null;

    // List of prompts
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void AddEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry()
        {
            _date = date,
            _prompt = prompt,
            _response = response
        };

        _entries.Add(newEntry);

        // Update the streak
        UpdateStreak(DateTime.Now);

        Console.WriteLine("Your journal entry has been added!");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine("-----------------------------------");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine($"Journal saved to {fileName}");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._prompt = parts[1];
                    newEntry._response = parts[2];
                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void UpdateStreak(DateTime currentDate)
    {
        if (_lastEntryDate == null)
        {
            _streak = 1;
        }
        else
        {
            TimeSpan difference = currentDate.Date - _lastEntryDate.Value.Date;
            if (difference.Days == 1)
            {
                _streak++;
            }
            else if (difference.Days > 1)
            {
                _streak = 1;
            }
        }

        _lastEntryDate = currentDate;

        Console.WriteLine($"Current Streak: {_streak} day(s) in a row!\n");
    }

    public int GetStreak()
    {
        return _streak;
    }
}