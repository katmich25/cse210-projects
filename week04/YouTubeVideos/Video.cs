using System.Transactions;

public class Video
{
    private string _title;

    private string _author;
    
    private int _lengthSeconds;

    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)//Recibe un objeto Comment y lo agrega a _comments.
    {

        _comments.Add(comment);
    }

    public int NumberComments()//Devuelve la cantidad de comentarios que hay en _comments.
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string displayText = _title;
        displayText = displayText + "\nAuthor: " + _author;
        displayText = displayText + "\nLength: " + _lengthSeconds + " seconds";
        displayText = displayText + "\nComments: " + NumberComments();

        foreach (Comment comment in _comments)
        {
            displayText = displayText + "\n" + comment.GetDisplayText();
        }

        return displayText;
    }

}