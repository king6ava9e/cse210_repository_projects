using System;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    // Constructor for convenience
    public Entry() { }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Convert Entry to a string for saving
    public override string ToString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // Create Entry from a string (for loading)
    public static Entry FromString(string line)
    {
        var parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry
            {
                _date = parts[0],
                _prompt = parts[1],
                _response = parts[2]
            };
        }
        return null;
    }
}