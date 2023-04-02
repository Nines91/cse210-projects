using System;
public class Cycling : Activity
{
    private double _distance = 0;
    public Cycling(double time, string name, double distance) : base(time,name)
    {
       _distance = distance;
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