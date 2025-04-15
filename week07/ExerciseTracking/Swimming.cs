using System;
public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceMeters = 50;
    private const double MetersToMiles = 0.00062137;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * LapDistanceMeters * MetersToMiles;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}