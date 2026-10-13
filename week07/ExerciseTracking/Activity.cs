using System.Data.Common;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    
    public abstract double GetSpeed();
    
    public abstract double GetPace();


    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy", System.Globalization.CultureInfo.InvariantCulture)} {GetType().Name} ({GetMinutes()} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}