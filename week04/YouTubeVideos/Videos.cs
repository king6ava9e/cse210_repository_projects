using System;


public class Videos
{
    public string _Title;
    public string _Author;
    public int _Length; // in seconds

    List<Comment> _comments;
    // Constructor to initialize the video
    public Videos(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _comments = new List<Comment>();
    }
    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // method to GetNumberOfComments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


 }

