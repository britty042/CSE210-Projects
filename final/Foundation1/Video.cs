using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    //length of the video (in seconds)
    private int _length;
   
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetCommentsList(List<Comment> comments)
    {
        _comments = comments;
    }
    public void Display()
    {
       Console.WriteLine($"\nTitle: {_title} Author: {_author} Video Length in Seconds: {_length} Number of Comments: {_comments.Count()}");
       
       Console.WriteLine("Comments:");
       foreach (Comment comment in _comments)
       {
            comment.Display();
       }
    }


    public int NumberOfComments(string video)
    {       
        int commentAmount = _comments.Count();

        return commentAmount;
    }
    //store a list of comments

    //method to return the number of comments
}