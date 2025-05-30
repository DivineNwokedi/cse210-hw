using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _commentList;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _commentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _commentList.Count;
    }

    public string GetDisplayString()
    {
        string videoInfo = $"Title: {_title}\nAuthor: {_author}\nVideo Length: {_videoLength} minutes\nNumber of Comments: {GetNumberOfComments()}\n";
        string comments = "";
        foreach (Comment comment in _commentList)
        {
            comments += comment.GetDisplayString() + "\n";
        }
        return videoInfo + comments;
    }
}
