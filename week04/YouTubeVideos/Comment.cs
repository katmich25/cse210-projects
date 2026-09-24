public class Comment
{
    private string _personName;
    private string _comment;

    public Comment(string personName, string text) //Recibe y guarda cada informacion en su campo correspondiente.
    {
        _personName = personName;
        _comment = text;
    }

    public string GetDisplayText()
    {
        return $"{_personName}: {_comment}";
    }
}