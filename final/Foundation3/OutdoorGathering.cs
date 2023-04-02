using System;

public class OutdoorGathering : Events //Here OutdoorGathering class is a child class.
{
    private string _weather;
//Creating a new instance with the specified parameters.
    public OutdoorGathering (string type, string eventName, string descriptions, string date, string time,string address, string weather) : base(type, eventName, descriptions, date, time,address) 
    {
        _weather = weather;
    }

    public void OutdoorShortDescription() //This method inherit the shortDescription method from the Event parent class.
    {   
        Console.WriteLine("\n****** Short Descriprion Evenet ******\n");
        ShortDescription();
    }

    public void OutdoorStandardDetails() //This method inherit the StandardDetails method from the Event parent class.
    {
        Console.WriteLine("\n****** Standard Descriprion Evenet ******\n");
        StandardDetails();
    }
    public void FullDetail(string type)
    {
        Console.WriteLine("\n****** Full Descriprion Evenet ******\n");
        Console.WriteLine($"Event type: {type}");
        Console.WriteLine($"Weather: {_weather}");
        StandardDetails(); 
    }
}