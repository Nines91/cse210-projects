using System;

public class Activity 
{
    private string _name;
    private double _distance = 0;
    private double _time = 0;
    private double _pace=0;
    private double _speed = 0;
    public Activity(double time,string name)
    {
        _name = name;
        _time = time;
    }
    public void Date(){
        DateTime _currentDate = DateTime.Now;
        Console.Write($"{_currentDate.ToLongDateString()} ");        
    }
    public string GetName(){ return _name;}
    public void SetName(string name){ _name = name; }
    public double GetTime() { return _time;}
    public void SetTime(double time) {_time = time;}  
    public double GetDistance() { return _distance;}  
    public void SetDistance(double distance) {_distance = distance;}
    public virtual double Distance(){return _distance;}
    public virtual double Speed() {return _speed;}
    public virtual double Pace() { return _pace; }
    public virtual void GetSummary(double distance, double speed, double pace)
    {   Date();
        Console.WriteLine($"{_name}:({_time}min) - Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
}