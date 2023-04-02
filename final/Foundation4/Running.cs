using System;

public class Running : Activity
{   
    private double _distance = 0;
    public Running(double time, string name, double distance) : base(time, name)
    {
        GetName();
        _distance = distance;
        GetTime();
    }
    
    public override double Distance()
    {
        return _distance;
    }
     public override double Pace()
    {      
        return GetTime() / _distance;
    }
    public override double Speed()
    {
         return (_distance / GetTime()) * 60;
    }
   
    
}