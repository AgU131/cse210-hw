using System;
using System.Collections.Generic;

public class Video 
{
    private string _title;
    private string _author;
    private int _length; // in seconds

    // List to keep track of comments
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to add a comment to the video
    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to get video information
    public string GetVideoInfo()
    {
        return $"{_title} by {_author} ({_length} seconds) - {GetCommentCount()} comments";
    }

    // Method to get comments list
    public List<Comment> GetComments()
    {
        return _comments;
    }
}