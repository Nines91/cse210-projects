using System;

public class Events //This class will be the parent class.
{
    private string _eventType;
    private string _eventName;
    private string _descriptions;
    private string _date;
    private string _time;
    private string _address;

//Creating a new instance with the specified parameters.
public Events (string type, string eventName, string descriptions, string date, string time, string address) 
{
    _eventType = type;
    _eventName = eventName;
    _descriptions = descriptions;
    _date = date;
    _time = time;
    _address = address;
}

public void ShortDescription() //Making a short description method. This will be called in each event class.
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventName}");
        Console.WriteLine($"Date: {_date}");
    }
public void StandardDetails() //Making a standard description method. This will be called in each event class.
    {
        Console.WriteLine($"Title: {_eventName}");
        Console.WriteLine($"Descroption: {_descriptions}.");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}.");
    }
}