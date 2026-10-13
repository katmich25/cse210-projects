public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / GetMinutes() * 60;

        return speed;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}