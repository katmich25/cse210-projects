public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description} - {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }
}