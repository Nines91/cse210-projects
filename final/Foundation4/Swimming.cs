using System;

public class Swimming : Activity 
{
    private double _laps = 0;

    public Swimming(double time, string name, int laps) : base(time, name)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override double Pace()
    {      
        return GetTime() / Distance();
    }
    public override double Speed()
    {
         return (Distance() / GetTime()) * 60;
    }
}