using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }
    
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {GetShortName()} - {GetDescription()} - {GetPoints()}";
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    
}