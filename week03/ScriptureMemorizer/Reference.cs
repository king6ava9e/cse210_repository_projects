using System;

public class Reference
{private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _isRange;

   // constructor for a single verse
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _isRange = false;
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isRange = true;
    }

    // Method to get the reference as a string
     public string GetDisplayText()
    {
        if (_isRange)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}