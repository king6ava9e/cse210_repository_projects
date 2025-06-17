public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string summary = _date + " " + this.GetType().Name + " (" + _lengthInMinutes + " min): " +
                          "Distance " + GetDistance().ToString("0.0") + " km, Speed " + GetSpeed().ToString("0.0") + " kph, Pace: " + GetPace().ToString("0.0") + " min per km";
        return summary;
    }
}
